using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Presentation.Controllers.Api.Base;
using Microsoft.AspNetCore.Mvc;

namespace DongPhuong.Presentation.Controllers.Api;

[Route("api/[controller]")]
public class DrinksController(IDrinksCommandHandler commandHandler, IDrinksQueryHandler queryHandler) : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await queryHandler.HandleAsync<DrinkGetDto>());
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id) =>
        Ok(await queryHandler.HandleAsync<DrinkGetDto>(id));
}