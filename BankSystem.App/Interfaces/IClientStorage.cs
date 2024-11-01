using System.Linq.Expressions;
using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IClientStorage : IStorage<Client>
{
    void AddAccount(Guid client, Account account);
    Task AddAccountAsync(Guid client, Account account, CancellationToken token);
    void RemoveAccount(Guid client, Guid accountId);
    Task RemoveAccountAsync(Guid client, Guid accountId, CancellationToken token);
    void UpdateAccount(Guid client, Guid oldAccount, Account newAccount);
    Task UpdateAccountAsync(Guid client, Guid oldAccount, Account newAccount, CancellationToken token);
}