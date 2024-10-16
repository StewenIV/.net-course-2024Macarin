using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IEmployeeStorage : IStorage<Employee>
{
    bool IsEmployeeExist(Guid employeeId);
}