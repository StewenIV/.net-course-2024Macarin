using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
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

    public Client GetClientById(Guid clientId)
    {
        if (clientId == Guid.Empty)
            throw new ArgumentNullException(nameof(clientId));
        return _clientStorage.GetById(clientId);
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

    public List<Client> GetClients(Expression<Func<Client, bool>> filter,
        Func<IQueryable<Client>, IOrderedQueryable<Client>> orderBy, int page, int pageSize)
    {
        if (filter is null)
            throw new ArgumentNullException(nameof(filter));
        return _clientStorage.Get(filter, orderBy, page, pageSize);
    }

    public void UpdateClient(Client oldClient, Client newClient)
    {
        if (oldClient is null)
            throw new ArgumentNullException(nameof(oldClient));
        if (newClient is null)
            throw new ArgumentNullException(nameof(newClient));
        var byId = _clientStorage.GetById(oldClient.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        _clientStorage.Update(oldClient.Id, newClient);
    }

    public void RemoveClient(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        var byId = _clientStorage.GetById(client.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        _clientStorage.Delete(client.Id);
    }

    public void AddAdditionalAccount(Client client, List<Account> accounts)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (accounts is null)
            throw new ArgumentNullException(nameof(accounts));
        var byId = _clientStorage.GetById(client.Id);
        if (byId is null)
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

            _clientStorage.AddAccount(client.Id, account);
        }
    }

    public void UpdateAccount(Client client, Account updateAccount)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (updateAccount is null)
            throw new ArgumentNullException(nameof(updateAccount));
        var byId = _clientStorage.GetById(client.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        var clientAccounts = client.Accounts;
        var existingAccount = clientAccounts.Find(a => a.Currency.Code == updateAccount.Currency.Code);
        if (existingAccount is null)
            throw new ArgumentException("Account not found");
        if (Validator.TryValidateObject(updateAccount, new ValidationContext(updateAccount), null, true) == false)
            throw new ValidationException("Account is not valid");
        _clientStorage.UpdateAccount(client.Id, existingAccount.Id, updateAccount);
    }

    public void RemoveAccount(Client client, Account account)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (account is null)
            throw new ArgumentNullException(nameof(account));
        var byId = _clientStorage.GetById(client.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        _clientStorage.RemoveAccount(client.Id, account.Id);
    }
}