using System.ComponentModel.DataAnnotations;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class ClientService
{
    private readonly IClientStorage _clientStorage;

    public ClientService(IClientStorage clientStorage)
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
        _clientStorage.Add(client);
    }

    public Dictionary<Client, List<Account>> GetClients(Func<Client, bool> filter)
    {
        if(filter is null)
            throw new ArgumentNullException(nameof(filter));
        return _clientStorage.Get(filter);
    }

    public void UpdateClient(Client oldClient, Client newClient)
    {
        if (oldClient is null)
            throw new ArgumentNullException(nameof(oldClient));
        if (newClient is null)
            throw new ArgumentNullException(nameof(newClient));
        if (!_clientStorage.Get(c => Equals(c, oldClient)).Any())
            throw new ArgumentException("Client not found");
        _clientStorage.Update(oldClient, newClient);
    }

    public void RemoveClient(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (!_clientStorage.Get(c => Equals(c, client)).Any())
            throw new ArgumentException("Client not found");
        _clientStorage.Delete(client);
    }

    public void AddAdditionalAccount(Client client, List<Account> accounts)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (accounts is null)
            throw new ArgumentNullException(nameof(accounts));
        if (!_clientStorage.Get(c => Equals(c, client)).Any())
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

        _clientStorage.AddAccount(client, accounts);
    }

    public void UpdateAccount(Client client, Account updateAccount)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (updateAccount is null)
            throw new ArgumentNullException(nameof(updateAccount));
        if (!_clientStorage.Get(c => Equals(c, client)).Any())
            throw new ArgumentException("Client not found");
        var clientAccounts = _clientStorage.Get(c => Equals(c, client)).First().Value;
        var existingAccount = clientAccounts.Find(a => a.Currency.Code == updateAccount.Currency.Code);
        if (existingAccount is null)
            throw new ArgumentException("Account not found");
        if (Validator.TryValidateObject(updateAccount, new ValidationContext(updateAccount), null, true) == false)
            throw new ValidationException("Account is not valid");
        existingAccount.Amount = updateAccount.Amount;
    }

    public void RemoveAccount(Client client, Account account)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (account is null)
            throw new ArgumentNullException(nameof(account));
        if (!_clientStorage.Get(c => Equals(c, client)).Any())
            throw new ArgumentException("Client not found");
        _clientStorage.RemoveAccount(client, account);
    }
}