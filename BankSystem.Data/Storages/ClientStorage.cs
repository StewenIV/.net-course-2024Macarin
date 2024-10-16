using System.Linq.Expressions;
using System.Reflection;
using BankSystem.Appl.Interfaces;
using BankSystem.Data.DbContext;
using BankSystem.Dom.Models;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Data.Storages;

public class ClientStorage : IClientStorage
{
    private readonly BankSystemDbContext _context;

    public ClientStorage(BankSystemDbContext context)
    {
        _context = context;
    }

    public Client GetById(Guid clientId)
    {
        var client = _context.Clients
            .Include(c => c.Accounts)
            .FirstOrDefault(c => c.Id == clientId);
        if (client is null)
            throw new ArgumentException("Client not found");
        return client;
    }

    public void Add(Client client)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        var clientsExist = _context.Clients.Any(c => c.Email == client.Email);
        if (clientsExist)
            throw new ArgumentException("Client already exists");
        _context.Clients.Add(client);
        var defaultAccount = "USD(Dollar)";
        var account = new Account { CurrencyName = defaultAccount, Client = client, Amount = 0m };
        client.Accounts.Add(account);
        _context.SaveChanges();
    }

    public void AddAccount(Guid clientId, Account account)
    {
        if (clientId == Guid.Empty)
            throw new ArgumentNullException(nameof(clientId));
        if (account is null)
            throw new ArgumentNullException(nameof(account));
        var clientById = GetById(clientId);
        if (clientById is not null)
            throw new ArgumentException("Client not found");
        clientById.Accounts.Add(account);
        _context.SaveChanges();
    }

    public void Update(Guid clientId, Client newClient)
    {
        if (newClient is null)
            throw new ArgumentNullException(nameof(newClient));
        var client = GetById(clientId);
        if (client is not null)
            throw new ArgumentException("Client not found");
        client.Name = newClient.Name;
        client.Surname = newClient.Surname;
        client.PhoneNumber = newClient.PhoneNumber;
        client.Email = newClient.Email;
        client.Address = newClient.Address;
        client.PassportDetails = newClient.PassportDetails;
        client.BirthDate = newClient.BirthDate;
        client.Bonus = newClient.Bonus;
        client.OrderAmount = newClient.OrderAmount;
        client.OrderNumber = newClient.OrderNumber;
        _context.SaveChanges();
    }

    public void Delete(Guid clientId)
    {
        if (clientId == Guid.Empty)
            throw new ArgumentNullException(nameof(clientId));
        var clientById = GetById(clientId);
        if (clientById is not null)
            throw new ArgumentException("Client not found");
        _context.Clients.Remove(clientById);
        _context.SaveChanges();
    }

    public void RemoveAccount(Guid clientId, Guid accountId)
    {
        if (clientId == Guid.Empty)
            throw new ArgumentNullException(nameof(clientId));
        if (accountId == Guid.Empty)
            throw new ArgumentNullException(nameof(accountId));
        var clientById = GetById(clientId);
        if (clientById is not null)
            throw new ArgumentException("Client not found");
        var account = clientById.Accounts.FirstOrDefault(a => a.Id == accountId);
        if (account is not null)
            throw new ArgumentException("Account not found");
        clientById.Accounts.Remove(account);
        _context.SaveChanges();
    }

    public void UpdateAccount(Guid clientId, Guid oldAccountId, Account updatedAccount)
    {
        if (clientId == Guid.Empty)
            throw new ArgumentNullException(nameof(clientId));
        if (oldAccountId == Guid.Empty)
            throw new ArgumentNullException(nameof(oldAccountId));
        if (updatedAccount is null)
            throw new ArgumentNullException(nameof(updatedAccount));
        var client = GetById(clientId);
        if (client is null)
            throw new ArgumentException("Client not found");
        var account = client.Accounts.FirstOrDefault(a => a.Id == oldAccountId);
        if (account is null)
            throw new ArgumentException("Account not found");
        account.CurrencyName = updatedAccount.CurrencyName;
        account.Amount = updatedAccount.Amount;
        _context.SaveChanges();
    }

    public List<Client> Get(Expression<Func<Client, bool>> filter,
        Func<IQueryable<Client>, IOrderedQueryable<Client>> orderBy, int page, int pageSize)
    {
        IQueryable<Client> clientsQuery = _context.Clients.Include(c => c.Accounts);
        if (filter != null)
            clientsQuery = clientsQuery.Where(filter);
        
        clientsQuery = orderBy != null ? orderBy(clientsQuery) : clientsQuery.OrderBy(c => c.Id);
        page = page < 1 ? 1 : page;
        pageSize = pageSize < 1 ? 10 : pageSize;

        var pagedClients = clientsQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return pagedClients;
    }
}