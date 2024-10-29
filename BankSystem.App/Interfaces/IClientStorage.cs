using System.Linq.Expressions;
using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IClientStorage : IStorage<Client>
{
    void AddAccount(Guid client, Account account);
    Task AddAccountAsync(Guid client, Account account);
    void RemoveAccount(Guid client, Guid accountId);
    Task RemoveAccountAsync(Guid client, Guid accountId);
    void UpdateAccount(Guid client, Guid oldAccount, Account newAccount);
    Task UpdateAccountAsync(Guid client, Guid oldAccount, Account newAccount);
}