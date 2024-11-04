using System.Linq.Expressions;
using BankSystem.Dom.Models;
using LinqKit;

namespace BankSystem.Appl.DTOs;

public class EmployeeSearchParametrs
{
    public string? Name { get; set; }
    public int? MinAge { get; set; }
    public int? MaxAge { get; set; }
    public OrderByForEmployee? SortBy { get; set; }
    public bool SortDescending { get; set; } = false;
    public int? Page { get; set; } = 1;
    public int? PageSize { get; set; } = 10;

    public Expression<Func<Employee, bool>> GetFilter()
    {
        var filter = PredicateBuilder.New<Employee>(true);

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

    public Func<IQueryable<Employee>, IOrderedQueryable<Employee>> GetOrderBy()
    {
        return SortBy switch
        {
            OrderByForEmployee.Name => c => SortDescending ? c.OrderByDescending(empl => empl.Name) : c.OrderBy(empl => empl.Name),
            OrderByForEmployee.Surname => c => SortDescending ? c.OrderByDescending(empl => empl.Surname) : c.OrderBy(empl => empl.Surname),
            OrderByForEmployee.BirthDate => c => SortDescending ? c.OrderByDescending(empl => empl.BirthDate) : c.OrderBy(empl => empl.BirthDate),
            _ => c => c.OrderBy(client => client.Name), 
        };
    }
}
public enum OrderByForEmployee
{
    Null = 0,
    Name = 1,
    Surname = 2,
    BirthDate = 3
}