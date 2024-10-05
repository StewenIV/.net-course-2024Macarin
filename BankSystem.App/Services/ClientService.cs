using System.ComponentModel.DataAnnotations;
using BankSystem.Appl.Exceptions;
using BankSystem.Data.Storages;
using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class ClientService
{
    private readonly ClientStorage _clientStorage;

    public ClientService(ClientStorage clientStorage)
    {
        _clientStorage = clientStorage;
    }

    public void AddClient(Client client)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(client);
        bool isValid = Validator.TryValidateObject(client, validationContext, validationResults, true);
        if (!isValid)
        {
            var errorMessage = string.Join("; ", validationResults.Select(vr => vr.ErrorMessage));
            throw new ValidationException($"Client is not valid: {errorMessage}");
        }

        if (client.Age < 18)
            throw new InvalidPersonAgeException("Client is under 18");
        if (client.PassportDetails is null)
            throw new PassportDetailsNullException(nameof(client.PassportDetails));

        var dollarAccount = new List<Account>()
        {
            new()
            {
                Currency = new Currency
                {
                    Name = "Dollar",
                    Code = CurrencyCode.Usd
                },
                Amount = 0m
            }
        };
        _clientStorage.AddClient(client, dollarAccount);
    }

    public void AddAdditionalAccount(Client client, List<Account> accounts)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (accounts is null)
            throw new ArgumentNullException(nameof(accounts));
        if (!_clientStorage.Clients.ContainsKey(client))
            throw new ArgumentException("Client not found");
        foreach (var account in accounts)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(account);
            bool isValid = Validator.TryValidateObject(account, validationContext, validationResults, true);
            if (!isValid)
            {
                var errorMessage = string.Join("; ", validationResults.Select(vr => vr.ErrorMessage));
                throw new ValidationException($"Account is not valid: {errorMessage}");
            }
        }

        _clientStorage.Clients[client].AddRange(accounts);
    }

    public void UpdateAccount(Client client, Account updateAccount)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (updateAccount is null)
            throw new ArgumentNullException(nameof(updateAccount));
        if (!_clientStorage.Clients.ContainsKey(client))
            throw new ArgumentException("Client not found");
        var clientAccounts = _clientStorage.Clients[client];
        var existingAccount = clientAccounts.Find(a => a.Currency.Code == updateAccount.Currency.Code);
        if (existingAccount is null)
            throw new ArgumentException("Account not found");
        if (Validator.TryValidateObject(updateAccount, new ValidationContext(updateAccount), null, true) == false)
            throw new ValidationException("Account is not valid");
        existingAccount.Amount = updateAccount.Amount;
    }

    public Dictionary<Client, List<Account>> GetClients(string name = null, string surname = null,
        string phoneNumber = null,
        string passportDetails = null, DateTime start = default, DateTime end = default)
    {
        if (end == default)
            end = DateTime.Now;
        var clients = _clientStorage.Clients.Where(c => (name == null || c.Key.Name == name) &&
                                                        (surname == null || c.Key.Surname == surname) &&
                                                        (phoneNumber == null || c.Key.PhoneNumber == phoneNumber) &&
                                                        (passportDetails == null ||
                                                         c.Key.PassportDetails == passportDetails) &&
                                                        ((start == default || c.Key.BirthDate >= start) &&
                                                         (end != default || c.Key.BirthDate <= end)))
            .ToDictionary(c => c.Key, c => c.Value);
        return clients;
    }
}