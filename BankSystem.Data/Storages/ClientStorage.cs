using System.Reflection;
using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Storages;

public class ClientStorage : IClientStorage
{
    private readonly Dictionary<Client, List<Account>> _clients;

    public ClientStorage(Dictionary<Client, List<Account>> clients)
    {
        _clients = clients;
    }

    public void Add(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        var accounts = new List<Account>()
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
        if (!_clients.TryAdd(client, accounts))
            throw new ArgumentException("Client already exists");
    }

    public Dictionary<Client, List<Account>> Get(Func<Client, bool> filter)
    {
        if (filter is null)
            throw new ArgumentNullException(nameof(filter));
        return _clients.Where(kvp => filter(kvp.Key)).ToDictionary(kpv => kpv.Key, kpv => kpv.Value);
    }

    public void Update(Client oldClient, Client newClient)
    {
        if (oldClient is null)
            throw new ArgumentNullException(nameof(oldClient));
        if (newClient is null)
            throw new ArgumentNullException(nameof(newClient));
        if (!_clients.ContainsKey(oldClient))
            throw new ArgumentException("Client not found");
        var accounts = _clients[oldClient];
        _clients.Remove(oldClient);
        _clients.Add(newClient, accounts);
    }

    public void Delete(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (!_clients.ContainsKey(client))
            throw new ArgumentException("Client not found");
        _clients.Remove(client);
    }

    public void AddAccount(Client client, List<Account> accounts)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (accounts is null)
            throw new ArgumentNullException(nameof(accounts));
        if (!_clients.ContainsKey(client))
            throw new ArgumentException("Client not found");
        _clients[client].AddRange(accounts);
    }

    public void RemoveAccount(Client client, Account account)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (account is null)
            throw new ArgumentNullException(nameof(account));
        if (!_clients.ContainsKey(client))
            throw new ArgumentException("Client not found");
        if (!_clients[client].Remove(account))
            throw new ArgumentException("Account not found");
    }

    public void UpdateAccount(Client client, Account oldAccount, Account newAccount)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (oldAccount is null)
            throw new ArgumentNullException(nameof(oldAccount));
        if (newAccount is null)
            throw new ArgumentNullException(nameof(newAccount));
        if (!_clients.ContainsKey(client))
            throw new ArgumentException("Client not found");
        if (!_clients[client].Remove(oldAccount))
            throw new ArgumentException("Account not found");
        _clients[client].Add(newAccount);
    }
}