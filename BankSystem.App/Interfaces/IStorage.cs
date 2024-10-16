using System.Linq.Expressions;
using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IStorage<T>
{
    List<T> Get(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
        int page, int pageSize);
    void Add(T item);
    void Delete(Guid item);
    void Update(Guid item, T newItem); 
    T GetById(Guid id);
}