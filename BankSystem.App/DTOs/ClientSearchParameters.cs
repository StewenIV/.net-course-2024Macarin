using System.Linq.Expressions;
using BankSystem.Dom.Models;
using LinqKit;

namespace BankSystem.Appl.DTOs;

public class ClientSearchParameters
{
    public string? Name { get; set; }
    public int? MinAge { get; set; }
    public int? MaxAge { get; set; }
    public OrderByForClient? SortBy { get; set; }
    public bool SortDescending { get; set; } = false;
    public int? Page { get; set; } = 1;
    public int? PageSize { get; set; } = 10;

    public Expression<Func<Client, bool>> GetFilter()
    {
        var filter = PredicateBuilder.New<Client>(true);

        if (!string.IsNullOrWhiteSpace(Name))
        {
            filter = filter.And(c => c.Name.Contains(Name) || c.Surname.Contains(Name));
        }

        if (MinAge.HasValue)
        {
            var minBirthDate = DateTime.Now.AddYears(-MinAge.Value).ToUniversalTime(); 
            filter = filter.And(c => c.BirthDate <= minBirthDate); 
        }

        if (MaxAge.HasValue)
        {
            var maxBirthDate = DateTime.Now.AddYears(-MaxAge.Value).ToUniversalTime(); 
            filter = filter.And(c => c.BirthDate >= maxBirthDate); 
        }

        return filter;
    }

    public Func<IQueryable<Client>, IOrderedQueryable<Client>> GetOrderBy()
    {
        return SortBy switch
        {
            OrderByForClient.Name => c => SortDescending ? c.OrderByDescending(client => client.Name) : c.OrderBy(client => client.Name),
            OrderByForClient.Surname => c => SortDescending ? c.OrderByDescending(client => client.Surname) : c.OrderBy(client => client.Surname),
            OrderByForClient.BirthDate => c => SortDescending ? c.OrderByDescending(client => client.BirthDate) : c.OrderBy(client => client.BirthDate),
            _ => c => c.OrderBy(client => client.Name), 
        };
    }

}

public enum OrderByForClient
{
    Null = 0,
    Name = 1,
    Surname = 2,
    BirthDate = 3
}
