using System.Linq.Expressions;
using BankSystem.Appl.DTOs;
using BankSystem.Appl.Interfaces;
using BankSystem.Dom.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet("{clientId}")]
    public async Task<IActionResult> GetClientById([FromRoute] Guid clientId, CancellationToken cancellationToken)
    {
        var response = await _clientService.GetByIdAsync(clientId, cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> AddClient([FromBody] ClientDto client, CancellationToken cancellationToken)
    {
        await _clientService.AddAsync(client, cancellationToken);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateClient([FromQuery] Guid id, [FromBody] ClientDto updateClientDto,
        CancellationToken cancellationToken)
    {
        await _clientService.UpdateAsync(id, updateClientDto, cancellationToken);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveClient([FromQuery] Guid id, CancellationToken cancellationToken)
    {
        await _clientService.RemoveAsync(id, cancellationToken);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetClients([FromQuery] ClientSearchParameters filter, int page, int pageSize,
        CancellationToken cancellationToken)
    { 
        var response = await _clientService.GetAsync(filter, page, pageSize, cancellationToken);
        return Ok(response);
    }
}