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
        var result = await CurrencyService.GetCurrencyExchange(fromCurrency, toCurrency, amount);

        // Assert
        Assert.Equal(response.Error, result.Error);
        Assert.Equal(response.Error_message, result.Error_message);
        Assert.True(result.Amount > 0);
    }
}