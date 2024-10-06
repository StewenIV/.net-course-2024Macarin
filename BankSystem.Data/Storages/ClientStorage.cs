using System.Reflection;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Storages;

public class ClientStorage
{
    private readonly Dictionary<Client, List<Account>> _clients;

    public ClientStorage(Dictionary<Client, List<Account>> clients)
    {
        _clients = clients;
    }

    public Dictionary<Client, List<Account>> Clients => _clients;

    public void AddClient(Client client, List<Account> accounts)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (!_clients.TryAdd(client, accounts))
            throw new ArgumentException("Client already exists");
    }
    
    public void AddAdditionalAccount(Client client, List<Account> accounts)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (accounts is null)
            throw new ArgumentNullException(nameof(accounts));
        if (!_clients.ContainsKey(client))
            throw new ArgumentException("Client not found");
        _clients[client].AddRange(accounts);
    }

    public Client GetYoungestClient()
    {
        if (!_clients.Any())
            throw new InvalidOperationException("No clients in storage");
        return _clients.Aggregate((youngest, next) => next.Key.Age < youngest.Key.Age ? next : youngest).Key;
    }

    public Client GetOldestClient()
    {
        if (!_clients.Any())
            throw new InvalidOperationException("No clients in storage");
        return _clients.Aggregate((oldest, next) => next.Key.Age > oldest.Key.Age ? next : oldest).Key;
    }

    public int GetAverageAge()
    {
        if (!_clients.Any())
            throw new InvalidOperationException("No clients in storage");
        return (int)_clients.Average(x => x.Key.Age);
    }

    public void RemoveClient(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (!_clients.ContainsKey(client))
            throw new ArgumentException("Client not found");
        _clients.Remove(client);
    }
}