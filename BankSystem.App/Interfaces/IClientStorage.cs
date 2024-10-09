using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IClientStorage: IStorage<Client>
{
    
    Dictionary<Client,List<Account>> Get(Func<Client, bool> filter);
    void AddAccount(Client client, List<Account> account);
    void RemoveAccount(Client client, Account account);
    void UpdateAccount(Client client, Account oldAccount, Account newAccount);
}