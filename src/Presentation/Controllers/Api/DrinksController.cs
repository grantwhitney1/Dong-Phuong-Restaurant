using DongPhuong.Application.Requests.Features.Base;
using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Presentation.Controllers.Api.Base;
using Microsoft.AspNetCore.Mvc;

namespace DongPhuong.Presentation.Controllers.Api;

[Route("api/[controller]")]
public class DrinksController(IDrinksCommandHandler commandHandler, IDrinksQueryHandler queryHandler)
    : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await queryHandler.HandleAsync<DrinkGetDto>());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        return Ok(await queryHandler.HandleAsync<DrinkGetDto>(id));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PostRequest<DrinkDto> request)
    {
        var response = await commandHandler.HandleAsync(request);
        if (response.Errors.Any())
            return BadRequest(response);
        return Ok(response);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PutRequest<DrinkDto?> request)
    {
        var response = await commandHandler.HandleAsync(id, request);
        if (response.Errors.Any())
            return BadRequest(response);
        return Ok(response);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var response = await commandHandler.HandleAsync(id);
        if (response.Errors.Any())
            return NotFound(response);
        return Ok(response);
    }
}