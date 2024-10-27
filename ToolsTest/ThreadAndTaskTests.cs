using System.Text;
using System.Text.RegularExpressions;
using BankSystem.App.Services;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using ExportTool;
using Newtonsoft.Json;

namespace ExportToolTests;

public class ThreadAndTaskTests
{
    private readonly Semaphore _semaphore = new(1, 1);
    private const int MaxFileSize = 1024 * 5;
    private int _fileCounter = 0;
    private long _fileSize = 0;

    [Fact]
    public void ExportClientsWithThread_ShouldExportClients_WhenPathIsValid()
    {
        //Arrange
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var pathToDirectory = Path.Combine(projectPath!, "Export");
        var generatedСlients = TestDataGenerator.GenerateClients(100);
        var threadCount = 10;
        var countDowm = new CountdownEvent(threadCount);

        //Act
        foreach (var batchClient in SplitClients(generatedСlients, threadCount))
        {
            ThreadPool.QueueUserWorkItem(_ =>
            {
                _semaphore.WaitOne();
                try
                {
                    var clients = batchClient.ToList();
                    var nameFile = $"clients{_fileCounter}.json";
                    foreach (var client in clients)
                    {
                        var pathToFile = Path.Combine(pathToDirectory, nameFile);
                        ExportService.ExportEntityToJson(client, pathToDirectory, nameFile);
                        if (File.Exists(pathToFile) && new FileInfo(pathToFile).Length > MaxFileSize)
                        {
                            CutFile(pathToFile);
                            _fileCounter++;
                            nameFile = $"clients{_fileCounter}.json";
                            ExportService.ExportEntityToJson(client, pathToDirectory, nameFile);
                        }
                    }
                }
                finally
                {
                    _semaphore.Release();
                    countDowm.Signal();
                }
            });
        }

        countDowm.Wait();
        
    }

    [Fact]
    public void CheckDeserialization_ShouldInportClients_WhenClientsAreExported()
    {
        var projectPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        var pathToDirectory = Path.Combine(projectPath!, "Export");
        var regex = new Regex(@"^clients\d+\.json$");
        foreach(var file in Directory.GetFiles(pathToDirectory, "*.json"))
        {
            var fileName = Path.GetFileName(file);
            if(regex.IsMatch(fileName))
            {
                var clients = ExportService.ImportEntityFromJson<List<Client>>(pathToDirectory, file);
                Assert.NotNull(clients);
            }
        }
    }

    [Fact]
    public void ParallelAddFunds_ShouldEqualExpectedBalance()
    {
        //Arrange
        var account = new Account();
        var expectedBalance = 2000m;
        var threadCount = 2;
        var iterations = 10;
        var amountToAdd = 100m;
        var semaphore = new Semaphore(1, 1);
        var countDowm = new CountdownEvent(threadCount);
        
        //Act
        for(int i = 0; i < threadCount; i++)
        {
            ThreadPool.QueueUserWorkItem(_ =>
            {
                for(int j = 0; j < iterations; j++)
                {
                    semaphore.WaitOne();
                    try
                    {
                        account.Amount += amountToAdd;
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                }
                countDowm.Signal();
            });
        }

        countDowm.Wait();
        
        //Assert
        Assert.Equal(expectedBalance, account.Amount);
    }
    
    private void CutFile(string pathToFile)
    {
        using (var stream = new FileStream(pathToFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            using (var reader = new StreamReader(stream))
            {
                using (var writer = new StreamWriter(stream))
                {
                    var fileContent = reader.ReadToEnd();
                    var lastRightBrace = fileContent.LastIndexOf('}');
                    var lastLeftBrace = fileContent.LastIndexOf('{');
                    var lastComma = fileContent.LastIndexOf(',', lastLeftBrace - 1);
                    if (lastRightBrace > lastLeftBrace && lastRightBrace != -1 &&
                        lastLeftBrace != -1 && lastComma != -1)
                    {
                        var remainingContent = fileContent.Substring(lastRightBrace + 1);
                        stream.Seek(lastComma, SeekOrigin.Begin);
                        stream.SetLength(lastComma + 1);
                        var newBytes = Encoding.UTF8.GetBytes(remainingContent);
                        writer.Write(remainingContent, 0, newBytes.Length);
                    }
                }
            }
        }
    }

    private IEnumerable<IEnumerable<Client>> SplitClients(List<Client> clients, int parts)
    {
        var batchSize = (int)Math.Ceiling((double)clients.Count / parts);
        for (var i = 0; i < clients.Count; i += batchSize)
        {
            yield return clients.Skip(i).Take(batchSize);
        }
    }
}