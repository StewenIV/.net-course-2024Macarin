using System.Linq.Expressions;
using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IStorage<T>
{
    List<T> Get(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
        int page, int pageSize);
    Task<List<T>?> GetAsync(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
        int page, int pageSize, CancellationToken token);
    void Add(T item);
    Task AddAsync(T item, CancellationToken token);
    void Delete(Guid item);
    Task DeleteAsync(Guid item, CancellationToken token);
    void Update(Guid item, T newItem);
    Task UpdateAsync(Guid item, T newItem, CancellationToken token);
    T GetById(Guid id);
    Task<T?> GetByIdAsync(Guid id, CancellationToken token);
}