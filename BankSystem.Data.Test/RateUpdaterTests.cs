using BankSystem.App.Services;
using BankSystem.Data.DbContext;
using BankSystem.Data.Storages;

namespace BankSystem.Data.Test;

public class RateUpdaterTests
{
    [Fact]
    public async Task RateUpdater_AppliesInterestRateToClientsWithMonthlyPeriod()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var rateUpdater = new RateUpdater(storage);

        //Act
        var amountFirstClient = storage.Get(c => true, c => c.OrderBy(c => true), 1, 1).FirstOrDefault().Accounts
            .FirstOrDefault().Amount;
        await rateUpdater.StartAsync(CancellationToken.None);
        await Task.Delay(TimeSpan.FromDays(1));

        //Assert
        Assert.Equal(amountFirstClient * 1.01m, storage.Get(c => true, c => c.OrderBy(c => true), 1, 1).FirstOrDefault().Accounts
            .FirstOrDefault().Amount);
        await rateUpdater.StopAsync(CancellationToken.None);
    }

    [Fact]
    public async Task UpdatesRateAsync_ShouldHandleCancellation()
    {
        //Arrange
        using var context = new BankSystemDbContext();
        var storage = new ClientStorage(context);
        var rateUpdater = new RateUpdater(storage);
        using var cancellationTokenSource = new CancellationTokenSource();
        await cancellationTokenSource.CancelAsync();
        
        // Act
        var exception = await Record.ExceptionAsync(async () => 
        {
            await rateUpdater.UpdatesRateAsync(cancellationTokenSource.Token);
        });
        
        // Assert
        Assert.Null(exception);
    }
}