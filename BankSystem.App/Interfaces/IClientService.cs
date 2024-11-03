using BankSystem.Appl.DTOs;
using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IClientService : IService<ClientDto>
{
    List<ClientDto> Get(ClientSearchParameters searchParameters, int page, int pageSize);

    Task<List<ClientDto>?> GetAsync(ClientSearchParameters searchParameters, int page, int pageSize,
        CancellationToken token);

    void AddAdditionalAccount(Client client, List<Account> account);
    Task AddAdditionalAccountAsync(Client client, List<Account> account, CancellationToken token);
    void RemoveAccount(Client client, Account accountId);
    Task RemoveAccountAsync(Client client, Account accountId, CancellationToken token);
    void UpdateAccount(Client client, Account oldAccount, Account newAccount);
    Task UpdateAccountAsync(Client client, Account oldAccount, Account newAccount, CancellationToken token);
}