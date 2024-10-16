using System.Reflection;
using BankSystem.App.Services;
using BankSystem.Dom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BankSystem.Data.DbContext;

public class BankSystemDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Client?> Clients => Set<Client>();
    public DbSet<Account> Accounts => Set<Account>();
    public DbSet<Employee> Employees => Set<Employee>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var basePath =
            Path.Combine(Path.GetDirectoryName(typeof(BankSystemDbContext).Assembly.Location) ?? string.Empty,
                "DbContext");
        var appSettingsPath = Path.Combine(basePath, "appsettings.json");
        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile(appSettingsPath)
            .Build();
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var clients = TestDataGenerator.GenerateClients(1000);
        var employees = TestDataGenerator.GenerateEmployees(1000);
        modelBuilder.Entity<Client>().HasData(clients);
        modelBuilder.Entity<Employee>().HasData(employees);
        modelBuilder.Entity<Account>().HasData(
            new Account { Id = Guid.NewGuid(), Amount = 0m, CurrencyName = "USD(Dollar)", ClientId = clients[0].Id },
            new Account { Id = Guid.NewGuid(), Amount = 0m, CurrencyName = "EUR(Euro)", ClientId = clients[1].Id },
            new Account { Id = Guid.NewGuid(), Amount = 0m, CurrencyName = "RUB(Rub)", ClientId = clients[2].Id },
            new Account { Id = Guid.NewGuid(), Amount = 0m, CurrencyName = "EUR(Euro)", ClientId = clients[0].Id });
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}