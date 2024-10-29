using BankSystem.Appl.Interfaces;
using Microsoft.Extensions.Hosting;

namespace BankSystem.App.Services;

public class RateUpdater : BackgroundService
{
    private readonly IClientStorage _clientStorage;
    private readonly decimal _interestRate;
    private static readonly TimeSpan DailyCheckTime = TimeSpan.FromHours(8);

    public RateUpdater(IClientStorage clientStorage, decimal interestRate = 0.01m)
    {
        _clientStorage = clientStorage;
        _interestRate = interestRate;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var now = DateTime.Now.TimeOfDay;
            var delay = now < DailyCheckTime
                ? DailyCheckTime - now
                : DailyCheckTime - now + TimeSpan.FromDays(1);
            await Task.Delay(delay, stoppingToken);
            await UpdatesRateAsync(stoppingToken);
        }
    }

    public async Task UpdatesRateAsync(CancellationToken cancellationToken)
    {
        var clients = _clientStorage.Get(c => true, c => c.OrderBy(c => true), 1, 100);
        foreach (var client in clients)
        {
            foreach (var account in client.Accounts)
            {
                account.Amount += account.Amount * _interestRate;
            }

            _clientStorage.Update(client.Id, client);
        }
    }
}