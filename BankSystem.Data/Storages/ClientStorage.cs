using System.Reflection;
using BankSystem.Dom.Models;

namespace BankSystem.Data.Storages;

public class ClientStorage
{
    private readonly List<Client> _clients;

    public ClientStorage(List<Client> clients)
    {
        _clients = clients;
    }

    public List<Client> Clients => _clients;

    public void AddClient(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (_clients.Exists(c => c.Equals(client)))
            throw new ArgumentException("Client already exists");
        _clients.Add(client);
    }

    public Client GetYoungestClient()
    {
        if (!_clients.Any())
            throw new InvalidOperationException("No clients in storage");
        return _clients.Aggregate((youngest, next) => next.Age < youngest.Age ? next : youngest);
    }

    public Client GetOldestClient()
    {
        if (!_clients.Any())
            throw new InvalidOperationException("No clients in storage");
        return _clients.Aggregate((oldest, next) => oldest.Age < next.Age ? next : oldest);
    }

    public int GetAverageAge()
    {
        if (!_clients.Any())
            throw new InvalidOperationException("No clients in storage");
        return (int)_clients.Average(c => c.Age);
    }

    public void RemoveClient(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if (0 > _clients.IndexOf(client))
            throw new ArgumentException("Client not found");
        _clients.Remove(client);
    }
}