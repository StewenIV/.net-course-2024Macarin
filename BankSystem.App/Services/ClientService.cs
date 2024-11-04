using System.Collections;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Transactions;
using AutoMapper;
using BankSystem.Appl.DTOs;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class ClientService : IClientService
{
    private readonly IClientStorage _clientStorage;
    private readonly IMapper _mapper;
    private readonly ConcurrentQueue<WithdrawalRequest> _requestQueue = new();
    private readonly int _maxProcessingTasks = 5;
    private CancellationTokenSource _cancellationTokenSource;

    public ClientService(IClientStorage clientStorage, IMapper mapper)
    {
        _clientStorage = clientStorage;
        _mapper = mapper;
    }

    public ClientService(IClientStorage clientStorage)
    {
        _clientStorage = clientStorage;
    }

    public ClientDto GetById(Guid clientId)
    {
        if (clientId == Guid.Empty)
            throw new ArgumentNullException(nameof(clientId));
        var client = _clientStorage.GetById(clientId);
        var clientDto = _mapper.Map<ClientDto>(client);
        return clientDto;
    }

    public async Task<ClientDto?> GetByIdAsync(Guid clientId, CancellationToken cancellationToken = default)
    {
        if (clientId == Guid.Empty)
            throw new ArgumentNullException(nameof(clientId));
        var client = await _clientStorage.GetByIdAsync(clientId, cancellationToken);
        var clientDto = _mapper.Map<ClientDto>(client);
        return clientDto;
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
                    await ProcessWithdrawalAsync(request.ClientId, request.Amount, cancellationToken);
                }
            }
        }, cancellationToken);
    }

    public void StopProcessingRequests()
    {
        _cancellationTokenSource.Cancel();
    }

    private async Task ProcessWithdrawalAsync(Guid argClientId, decimal argAmount,
        CancellationToken cancellationToken = default)
    {
        using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
        var client = _clientStorage
            .GetAsync(c => c.Id == argClientId, c => c.OrderBy(c => true), 1, 1, cancellationToken).Result
            .FirstOrDefault();
        if (client is not null)
        {
            if (client.Accounts.Any(a => a.Amount >= argAmount))
            {
                var account = client.Accounts.First(a => a.Amount >= argAmount);
                account.Amount -= argAmount;
                await _clientStorage.UpdateAsync(client.Id, client, cancellationToken);
                scope.Complete();
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

    public void Add(ClientDto clientDto)
    {
        var client = _mapper.Map<Client>(clientDto);
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
        _clientStorage.Add(client);
    }

    public async Task AddAsync(ClientDto clientDto, CancellationToken cancellationToken = default)
    {
        var client = _mapper.Map<Client>(clientDto);
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
        await _clientStorage.AddAsync(client, cancellationToken);
    }

    public List<ClientDto> Get(ClientSearchParameters searchParameters, int page, int pageSize)
    {
        if (searchParameters is null)
            throw new ArgumentNullException(nameof(searchParameters));
        var filter = searchParameters.GetFilter();
        var orderBy = searchParameters.GetOrderBy();
        var response = _clientStorage.Get(filter, orderBy, page, pageSize);
        var clients = response.Select(c => _mapper.Map<ClientDto>(c)).ToList();
        return clients;
    }
    
    public async Task<List<ClientDto>?> GetAsync(ClientSearchParameters searchParameters, int page, int pageSize,
        CancellationToken cancellationToken = default)
    {
        if (searchParameters is null)
            throw new ArgumentNullException(nameof(searchParameters));
        var filter = searchParameters.GetFilter();
        var orderBy = searchParameters.GetOrderBy();
        var response = await _clientStorage.GetAsync(filter, orderBy, page, pageSize, cancellationToken);
        if (response != null)
        {
            return response.Select(c => _mapper.Map<ClientDto>(c)).ToList();
        }

        return null;
    }

    public void Update(Guid id, ClientDto newClientDto)
    {
        if (newClientDto is null)
            throw new ArgumentNullException(nameof(newClientDto));
        var newClient = _mapper.Map<Client>(newClientDto);
        var clientById = _clientStorage.GetById(id);
        if (clientById is null)
            throw new ArgumentException("Client not found");
        _clientStorage.Update(id, newClient);
    }

    public async Task UpdateAsync(Guid id, ClientDto newClientDto,
        CancellationToken cancellationToken = default)
    {
        if (newClientDto is null)
            throw new ArgumentNullException(nameof(newClientDto));
        var newClient = _mapper.Map<Client>(newClientDto);
        var clientById = await _clientStorage.GetByIdAsync(id, cancellationToken);
        if (clientById is null)
            throw new ArgumentException("Client not found");
        await _clientStorage.UpdateAsync(id, newClient, cancellationToken);
    }

    public void Remove(Guid id)
    {
        var clientById = _clientStorage.GetById(id);
        if (clientById is null)
            throw new ArgumentException("Client not found");
        _clientStorage.Delete(id);
    }

    public async Task RemoveAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var clientById = await _clientStorage.GetByIdAsync(id, cancellationToken);
        if (clientById is null)
            throw new ArgumentException("Client not found");
        await _clientStorage.DeleteAsync(id, cancellationToken);
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

    public async Task AddAdditionalAccountAsync(Client client, List<Account> accounts,
        CancellationToken cancellationToken = default)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (accounts is null)
            throw new ArgumentNullException(nameof(accounts));
        var byId = await _clientStorage.GetByIdAsync(client.Id, cancellationToken);
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

            await _clientStorage.AddAccountAsync(client.Id, account, cancellationToken);
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

    public async Task UpdateAccountAsync(Client client, Account oldAccount, Account updateAccount,
        CancellationToken cancellationToken = default)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (updateAccount is null)
            throw new ArgumentNullException(nameof(updateAccount));
        if (oldAccount is null)
            throw new ArgumentNullException(nameof(oldAccount));
        var byId = await _clientStorage.GetByIdAsync(client.Id, cancellationToken);
        if (byId is null)
            throw new ArgumentException("Client not found");
        if (oldAccount is null)
            throw new ArgumentException("Account not found");
        if (Validator.TryValidateObject(updateAccount, new ValidationContext(updateAccount), null, true) == false)
            throw new ValidationException("Account is not valid");
        await _clientStorage.UpdateAccountAsync(client.Id, oldAccount.Id, updateAccount, cancellationToken);
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

    public async Task RemoveAccountAsync(Client client, Account account, CancellationToken cancellationToken = default)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (account is null)
            throw new ArgumentNullException(nameof(account));
        var byId = await _clientStorage.GetByIdAsync(client.Id, cancellationToken);
        if (byId is null)
            throw new ArgumentException("Client not found");
        await _clientStorage.RemoveAccountAsync(client.Id, account.Id, cancellationToken);
    }
}