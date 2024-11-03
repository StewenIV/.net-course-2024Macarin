using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using AutoMapper;
using BankSystem.Appl.DTOs;
using BankSystem.Appl.Exceptions;
using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;

namespace BankSystem.App.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeStorage _employeeStorage;
    private readonly IMapper _mapper;

    public EmployeeService(IEmployeeStorage employeeStorage, IMapper mapper)
    {
        _employeeStorage = employeeStorage;
        _mapper = mapper;
    }

    public EmployeeService(IEmployeeStorage employeeStorage)
    {
        _employeeStorage = employeeStorage;
    }

    public bool IsEmployeeExist(Guid employeeId)
    {
        if (employeeId == Guid.Empty)
            throw new ArgumentNullException(nameof(employeeId));
        return _employeeStorage.IsEmployeeExist(employeeId);
    }

    public EmployeeDto GetById(Guid employeeId)
    {
        if (employeeId == Guid.Empty)
            throw new ArgumentNullException(nameof(employeeId));
        var employee = _employeeStorage.GetById(employeeId);
        return _mapper.Map<EmployeeDto>(employee);
    }

    public async Task<EmployeeDto?> GetByIdAsync(Guid employeeId, CancellationToken cancellationToken = default)
    {
        if (employeeId == Guid.Empty)
            throw new ArgumentNullException(nameof(employeeId));
        var employee = await _employeeStorage.GetByIdAsync(employeeId, cancellationToken);
        return _mapper.Map<EmployeeDto>(employee);
    }

    public void Add(EmployeeDto employeeDto)
    {
        var employee = _mapper.Map<Employee>(employeeDto);
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(employee);
        bool isValid = Validator.TryValidateObject(employee, validationContext, validationResults, true);
        if (!isValid)
        {
            var errorMessage = string.Join("; ", validationResults.Select(vr => vr.ErrorMessage));
            throw new ValidationException($"Client is not valid: {errorMessage}");
        }

        if (employee.Age < 18)
            throw new InvalidPersonAgeException("Client is under 18");
        if (employee.PassportDetails is null)
            throw new PassportDetailsNullException(nameof(employeeDto.PassportDetails));

        _employeeStorage.Add(employee);
    }

    public async Task AddAsync(EmployeeDto employeeDto, CancellationToken cancellationToken = default)
    {
        var employee = _mapper.Map<Employee>(employeeDto);
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(employee);
        var isValid = Validator.TryValidateObject(employee, validationContext, validationResults, true);
        if (!isValid)
        {
            var errorMessage = string.Join("; ", validationResults.Select(vr => vr.ErrorMessage));
            throw new ValidationException($"Client is not valid: {errorMessage}");
        }

        if (employee.Age < 18)
            throw new InvalidPersonAgeException("Client is under 18");
        if (employee.PassportDetails is null)
            throw new PassportDetailsNullException(nameof(employee.PassportDetails));

        await _employeeStorage.AddAsync(employee, cancellationToken);
    }

    public List<EmployeeDto> Get(EmployeeSearchParametrs searchParametrs, int page, int pageSize)
    {
        if (searchParametrs is null)
            throw new ArgumentNullException(nameof(searchParametrs));
        var filter = searchParametrs.GetFilter();
        var orderBy = searchParametrs.GetOrderBy();
        var response = _employeeStorage.Get(filter, orderBy, page, pageSize);
        var employees = response.Select(_mapper.Map<EmployeeDto>).ToList();
        return employees;
    }

    public async Task<List<EmployeeDto>?> GetAsync(EmployeeSearchParametrs searchParameters, int page, int pageSize,
        CancellationToken cancellationToken)
    {
        if (searchParameters is null)
            throw new ArgumentNullException(nameof(searchParameters));
        var filter = searchParameters.GetFilter();
        var orderBy = searchParameters.GetOrderBy();
        var response = await _employeeStorage.GetAsync(filter, orderBy, page, pageSize, cancellationToken);
        if (response != null)
        {
           return response.Select(c => _mapper.Map<EmployeeDto>(c)).ToList();
        }

        return null;
    }

    public void Update(Guid id, EmployeeDto newEmployeeDto)
    {
        if (newEmployeeDto is null)
            throw new ArgumentNullException(nameof(newEmployeeDto));
        var newEmployee = _mapper.Map<Employee>(newEmployeeDto);
        var byId = _employeeStorage.GetById(id);
        if (byId is null)
            throw new ArgumentException("Employee not found");
        _employeeStorage.Update(id, newEmployee);
    }

    public async Task UpdateAsync(Guid id, EmployeeDto newEmployeeDto,
        CancellationToken cancellationToken = default)
    {
        if (newEmployeeDto is null)
            throw new ArgumentNullException(nameof(newEmployeeDto));
        var newEmployee = _mapper.Map<Employee>(newEmployeeDto);
        var employeeById = await _employeeStorage.GetByIdAsync(id, cancellationToken);
        if (employeeById is null)
            throw new ArgumentException("Employee not found");
        await _employeeStorage.UpdateAsync(id, newEmployee, cancellationToken);
    }

    public void Remove(Guid id)
    {
        var employee = _employeeStorage.GetById(id);
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        _employeeStorage.Delete(employee.Id);
    }

    public async Task RemoveAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var employee = await _employeeStorage.GetByIdAsync(id, cancellationToken);
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        await _employeeStorage.DeleteAsync(id, cancellationToken);
    }
}