using System.Reflection;
using System.Web;
using BankSystem.Appl.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace BankSystem.App.Services;

public class CurrencyService
{
    public static async Task<CurrencyExchangeResponse> GetCurrencyExchange(string fromCurrency, string toCurrency,
        int amount = 1)
    {
        CurrencyExchangeResponse response;
        var uri = $"https://www.amdoren.com/api/currency.php";
        var builder =
            new UriBuilder(uri); 
        var query = HttpUtility.ParseQueryString(builder.Query);
        var path = Directory
            .GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty)?.Parent?.Parent
            ?.Parent?.FullName;
        var settingPath = Path.Combine(path ?? string.Empty, "BankSystem.App", "Settings");
        var configuration = new ConfigurationBuilder()
            .SetBasePath(settingPath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();


        query["api_key"] = configuration["AppSettings:CurrencyApiKey"];
        query["from"] = fromCurrency;
        query["to"] = toCurrency;
        query["amount"] = amount.ToString();
        builder.Query = query.ToString();
        using (var client = new HttpClient())
        {
            var result = await client.GetAsync(builder.Uri);
            result.EnsureSuccessStatusCode();
            var message = await result.Content.ReadAsStringAsync();
            response = JsonConvert.DeserializeObject<CurrencyExchangeResponse>(message)!;
        }

        return response;
    }
}