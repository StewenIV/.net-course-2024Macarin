using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using BankSystem.Appl.DTOs;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class ClientService
{
    private readonly IClientStorage _clientStorage;
    private readonly ConcurrentQueue<WithdrawalRequest> _requestQueue = new ConcurrentQueue<WithdrawalRequest>();
    private readonly List<Task> _processingTasks = new List<Task>();
    private readonly int _maxProcessingTasks = 5;
    private CancellationTokenSource _cancellationTokenSource;

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

    public async Task<Client> GetClientByIdAsync(Guid clientId)
    {
        if (clientId == Guid.Empty)
            throw new ArgumentNullException(nameof(clientId));
        return await _clientStorage.GetByIdAsync(clientId);
    }

    public void AddWithdrawalRequest(WithdrawalRequest request)
    {
        _requestQueue.Enqueue(request);
    }

    public async Task StartProcessingRequestsAsync()
    {
        _cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = _cancellationTokenSource.Token;

        await Task.Run(async () =>
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                while (_requestQueue.TryDequeue(out var request))
                {
                    await ProcessWithdrawalAsync(request.ClientId, request.Amount);
                }
            }
        }, cancellationToken);
    }

    public void StopProcessingRequests()
    {
        _cancellationTokenSource.Cancel();
    }

    private async Task ProcessWithdrawalAsync(Guid argClientId, decimal argAmount)
    {
        var client = _clientStorage.GetAsync(c => c.Id == argClientId, c => c.OrderBy(c => true), 1, 1).Result
            .FirstOrDefault();
        if (client is not null)
        {
            if (client.Accounts.Any(a => a.Amount >= argAmount))
            {
                var account = client.Accounts.First(a => a.Amount >= argAmount);
                account.Amount -= argAmount;
                await _clientStorage.UpdateAsync(client.Id, client);
            }
            else
            {
                throw new InvalidOperationException($"Недостаточно средств на счете клиента {argClientId}");
            }
        }
        else
        {
            throw new KeyNotFoundException($"Клиент с ID {argClientId} не найден");
        }
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

    public async Task AddClientAsync(Client client)
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
        await _clientStorage.AddAsync(client);
    }

    public List<Client> GetClients(Expression<Func<Client, bool>> filter,
        Func<IQueryable<Client>, IOrderedQueryable<Client>> orderBy, int page, int pageSize)
    {
        if (filter is null)
            throw new ArgumentNullException(nameof(filter));
        return _clientStorage.Get(filter, orderBy, page, pageSize);
    }

    public async Task<List<Client>> GetClientsAsync(Expression<Func<Client, bool>> filter,
        Func<IQueryable<Client>, IOrderedQueryable<Client>> orderBy, int page, int pageSize)
    {
        if (filter is null)
            throw new ArgumentNullException(nameof(filter));
        return await _clientStorage.GetAsync(filter, orderBy, page, pageSize);
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

    public async Task UpdateClientAsync(Client oldClient, Client newClient)
    {
        if (oldClient is null)
            throw new ArgumentNullException(nameof(oldClient));
        if (newClient is null)
            throw new ArgumentNullException(nameof(newClient));
        var byId = await _clientStorage.GetByIdAsync(oldClient.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        await _clientStorage.UpdateAsync(oldClient.Id, newClient);
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

    public async Task RemoveClientAsync(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        var byId = await _clientStorage.GetByIdAsync(client.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        await _clientStorage.DeleteAsync(client.Id);
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

    public async Task AddAdditionalAccountAsync(Client client, List<Account> accounts)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (accounts is null)
            throw new ArgumentNullException(nameof(accounts));
        var byId = await _clientStorage.GetByIdAsync(client.Id);
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

            await _clientStorage.AddAccountAsync(client.Id, account);
        }
    }

    public void UpdateAccount(Client client, Account oldAccount, Account updateAccount)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (updateAccount is null)
            throw new ArgumentNullException(nameof(updateAccount));
        if (oldAccount is null)
            throw new ArgumentNullException(nameof(oldAccount));
        var byId = _clientStorage.GetById(client.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        if (oldAccount is null)
            throw new ArgumentException("Account not found");
        if (Validator.TryValidateObject(updateAccount, new ValidationContext(updateAccount), null, true) == false)
            throw new ValidationException("Account is not valid");
        _clientStorage.UpdateAccount(client.Id, oldAccount.Id, updateAccount);
    }

    public async Task UpdateAccountAsync(Client client, Account oldAccount, Account updateAccount)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (updateAccount is null)
            throw new ArgumentNullException(nameof(updateAccount));
        if (oldAccount is null)
            throw new ArgumentNullException(nameof(oldAccount));
        var byId = await _clientStorage.GetByIdAsync(client.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        if (oldAccount is null)
            throw new ArgumentException("Account not found");
        if (Validator.TryValidateObject(updateAccount, new ValidationContext(updateAccount), null, true) == false)
            throw new ValidationException("Account is not valid");
        await _clientStorage.UpdateAccountAsync(client.Id, oldAccount.Id, updateAccount);
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

    public async Task RemoveAccountAsync(Client client, Account account)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (account is null)
            throw new ArgumentNullException(nameof(account));
        var byId = await _clientStorage.GetByIdAsync(client.Id);
        if (byId is null)
            throw new ArgumentException("Client not found");
        await _clientStorage.RemoveAccountAsync(client.Id, account.Id);
    }
}