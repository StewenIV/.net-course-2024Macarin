using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using BankSystem.App.Services;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using CsvHelper;

namespace ExportTool;

public class ExportService()
{
    public static void ExportClientsToCsv(string path, string name, List<Client> clients)
    {
        if (string.IsNullOrWhiteSpace(path))
            throw new ArgumentException("Path is null or empty");
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is null or empty");
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        var filePath = Path.Combine(path, name);
        using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            using (var streamWriter = new StreamWriter(fileStream, new UTF8Encoding(true)))
            {
                using (var writer = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    writer.WriteHeader<Client>();
                    writer.NextRecord();
                    writer.WriteRecords(clients);
                    writer.Flush();
                }
            }
        }
    }

    public static void ImportClientsFromCsv(string path, string name)
    {
        if (string.IsNullOrWhiteSpace(path))
            throw new ArgumentException("Path is null or empty");
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is null or empty");
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        var filePath = Path.Combine(path, name);
        if(!File.Exists(filePath))
            File.Create(filePath).Close();

        var regex = new Regex(
            "(?<OrderNumber>[^,]+),(?<OrderAmount>[^,]+),(?<Id>[^,]+)," +
            "(?<Name>[^,]+),(?<Surname>[^,]+),(?<PhoneNumber>[^,]+)," +
            "(?<Email>[^,]+),(?<Age>[^,]+),(?<Address>\"([^\"]*)\")," +
            "(?<PassportDetails>[^,]+),(?<BirthDate>[^,]+),(?<Bonus>[^,]+)");
        var dbContext = new BankSystemDbContext();
        var storage = new ClientStorage(dbContext);
        var service = new ClientService(storage);
        using (var fileStream = new FileStream(filePath, FileMode.Open))
        {
            using (var streamReader = new StreamReader(fileStream, new UTF8Encoding(true)))
            {
                var header = streamReader.ReadLine();
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var match = regex.Match(line);
                    if (match.Success)
                    {
                        var record = new Client
                        {
                            OrderNumber = int.Parse(match.Groups["OrderNumber"].Value),
                            OrderAmount = decimal.Parse(match.Groups["OrderAmount"].Value),
                            Id = Guid.Parse(match.Groups["Id"].Value),
                            Name = match.Groups["Name"].Value,
                            Surname = match.Groups["Surname"].Value,
                            PhoneNumber = match.Groups["PhoneNumber"].Value,
                            Email = match.Groups["Email"].Value,
                            Address = match.Groups["Address"].Value.Trim('"'),
                            PassportDetails = match.Groups["PassportDetails"].Value,
                            BirthDate = DateTime.ParseExact(match.Groups["BirthDate"].Value, "MM/dd/yyyy HH:mm:ss",
                                CultureInfo.InvariantCulture).ToUniversalTime(),
                            Bonus = decimal.Parse(match.Groups["Bonus"].Value, CultureInfo.InvariantCulture)
                        };
                        service.AddClient(record);
                    }
                }
            }
        }
    }
}