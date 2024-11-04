using BankSystem.Appl.DTOs;
using BankSystem.Dom.Models;

namespace BankSystem.Appl.Interfaces;

public interface IEmployeeService : IService<EmployeeDto>
{
    List<EmployeeDto> Get(EmployeeSearchParametrs searchParameters, int page, int pageSize);

    Task<List<EmployeeDto>?> GetAsync(EmployeeSearchParametrs searchParameters, int page, int pageSize,
        CancellationToken token);
    bool IsEmployeeExist(Guid employeeId);
}