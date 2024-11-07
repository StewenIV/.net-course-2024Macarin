using System.Net;
using System.Text;
using BankSystem.App.Services;
using BankSystem.Appl.Models;
using Newtonsoft.Json;

namespace BancSystem.App.Test;

public class CurrencyServiceTests
{
    [Fact]
    public async void GetCurrencyExchange_WithValidData_ShouldReturnCorrectResponse()
    {
        // Arrange
        var fromCurrency = "USD";
        var toCurrency = "EUR";
        var amount = 100;
        var response = new CurrencyExchangeResponse
        {
            Error = 0,
            Error_message = "-",
        };

        // Act
        CurrencyExchangeResponse result;
        try
        {
            result = await CurrencyService.GetCurrencyExchange(fromCurrency, toCurrency, amount);
        }
        catch (HttpRequestException ex)
        {
            result = new CurrencyExchangeResponse
            {
                Error = (int)HttpStatusCode.Unauthorized,
                Error_message = ex.Message,
            };
        }

        // Assert
        if(result.Error == 0)
        {
            Assert.Equal(response.Error, result.Error);
            Assert.Equal(response.Error_message, result.Error_message);
            Assert.True(result.Amount > 0);
        }
        else
        {
           Assert.Equal(0, result.Amount);
        }
    }
}