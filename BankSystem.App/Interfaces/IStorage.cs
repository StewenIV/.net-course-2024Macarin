using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IStorage<T>
{
    void Add(T item);
    void Delete(T item);
    void Update(T item, T newItem); 
}