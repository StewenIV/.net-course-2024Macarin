using System.Linq.Expressions;
using BankSystem.Appl.DTOs;
using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IService<T> 
{
    void Add(T item);
    Task AddAsync(T item, CancellationToken token);
    void Remove(Guid id);
    Task RemoveAsync(Guid id, CancellationToken token);
    void Update(Guid id, T newItem);
    Task UpdateAsync(Guid id, T newItem, CancellationToken token);
    T GetById(Guid id);
    Task<T?> GetByIdAsync(Guid id, CancellationToken token);
}