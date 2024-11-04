using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using AutoMapper;
using BankSystem.App.Services;
using BankSystem.Appl.DTOs;
using BankSystem.Appl.Mapping;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ExportTool;

public class ExportService()
{
    private static readonly IMapper Mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()));

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
        if (!File.Exists(filePath))
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
                        var clientDto = Mapper.Map<ClientDto>(record);
                        service.Add(clientDto);
                    }
                }
            }
        }
    }

    public static string ExportEntityToJson<T>(T entity, string path, string? name)
        where T : class
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new ArgumentException("Path is null or empty");
        }

        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var filePath = Path.Combine(path, name ?? $"{typeof(T).Name}.json");
        var jsonOutput = JsonConvert.SerializeObject(entity, Formatting.Indented);
        if (File.Exists(filePath) && new FileInfo(filePath).Length > 0 && new FileInfo(filePath).Extension == ".json")
        {
            AddToFile(filePath, jsonOutput);
        }
        else
        {
            File.WriteAllText(filePath, jsonOutput);
        }

        return jsonOutput;
    }

    private static void AddToFile(string pathToFile, string jsonText)
    {
        using (var stream = new FileStream(pathToFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            using (var reader = new StreamReader(stream))
            {
                using (var writer = new StreamWriter(stream))
                {
                    var fileContent = reader.ReadToEnd();
                    var lastRightBrace = fileContent.LastIndexOf('}');
                    var topBracket = fileContent.IndexOf('[');
                    var bottomBracket = fileContent.LastIndexOf(']');
                    if (lastRightBrace != -1 && topBracket != -1 && bottomBracket != -1)
                    {
                        var remainingContent = fileContent.Substring(lastRightBrace + 1);
                        stream.Seek(lastRightBrace + 1, SeekOrigin.Begin);
                        stream.Write(Encoding.UTF8.GetBytes(","), 0, 1);
                        stream.Write(Encoding.UTF8.GetBytes(jsonText));
                        stream.Write(Encoding.UTF8.GetBytes(remainingContent));
                    }
                    else if (topBracket == -1 && bottomBracket == -1)
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.Write(Encoding.UTF8.GetBytes("["), 0, 1);
                        stream.Seek(1, SeekOrigin.Begin);
                        stream.Write(Encoding.UTF8.GetBytes("{"), 0, 1);
                        var remainingContent = fileContent.Substring(lastRightBrace + 1);
                        stream.Seek(lastRightBrace, SeekOrigin.Begin);
                        writer.Write("}");
                        writer.Write(",");
                        writer.Write(jsonText);
                        writer.Write(remainingContent);
                        writer.Write("]");
                    }
                }
            }
        }
    }

    public static T ImportEntityFromJson<T>(string path, string name)
        where T : class
    {
        if (string.IsNullOrWhiteSpace(path))
            throw new ArgumentException("Path is null or empty");
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is null or empty");
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        var filePath = Path.Combine(path, name);
        if (!File.Exists(filePath))
            File.Create(filePath).Close();

        var json = File.ReadAllText(filePath);
        var passedType = typeof(T);
        if (typeof(IEnumerable).IsAssignableFrom(passedType))
        {
            if (json.Contains('[') && json.Contains(']'))
            {
                return JsonConvert.DeserializeObject<T>(json);
            }

            var singleObject = JsonConvert.DeserializeObject(json, passedType.GetGenericArguments()[0]);
            var collection = (IList)Activator.CreateInstance(passedType);
            collection.Add(singleObject);
            return (T)collection;
        }

        return JsonConvert.DeserializeObject<T>(json);
    }
}