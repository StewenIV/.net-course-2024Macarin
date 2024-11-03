using BankSystem.Appl.DTOs;
using BankSystem.Appl.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _emlpoyeeService;

    public EmployeeController(IEmployeeService emlpoyeeService)
    {
        _emlpoyeeService = emlpoyeeService;
    }

    [HttpGet("{employeeId}")]
    public async Task<IActionResult> GetEmployeeById([FromRoute] Guid employeeId,
        CancellationToken cancellationToken)
    {
        var response = await _emlpoyeeService.GetByIdAsync(employeeId, cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> AddClient([FromBody] EmployeeDto empoyee, CancellationToken cancellationToken)
    {
        await _emlpoyeeService.AddAsync(empoyee, cancellationToken);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateClient([FromQuery] Guid id, [FromBody] EmployeeDto updateClientDto,
        CancellationToken cancellationToken)
    {
        await _emlpoyeeService.UpdateAsync(id, updateClientDto, cancellationToken);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveClient([FromQuery] Guid id, CancellationToken cancellationToken)
    {
        await _emlpoyeeService.RemoveAsync(id, cancellationToken);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetClients([FromQuery] EmployeeSearchParametrs filter, int page, int pageSize,
        CancellationToken cancellationToken)
    {
        var response = await _emlpoyeeService.GetAsync(filter, page, pageSize, cancellationToken);
        return Ok(response);
    }
}
