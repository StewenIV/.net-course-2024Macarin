using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IEmployeeStorage : IStorage<Employee>
{
    List<Employee> Get(Func<Employee, bool> filter);
}