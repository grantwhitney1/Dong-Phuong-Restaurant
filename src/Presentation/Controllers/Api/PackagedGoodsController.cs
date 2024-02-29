using DongPhuong.Application.Requests.Features.Base;
using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;
using DongPhuong.Presentation.Controllers.Api.Base;
using Microsoft.AspNetCore.Mvc;

namespace DongPhuong.Presentation.Controllers.Api;

[Route("api/[controller]")]
public class PackagedGoodsController(
    IPackagedGoodsCommandHandler commandHandler,
    IPackagedGoodsQueryHandler queryHandler) : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await queryHandler.HandleAsync<PackagedGoodGetDto>());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        return Ok(await queryHandler.HandleAsync<PackagedGoodGetDto>(id));
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PostRequest<PackagedGoodDto> request)
    {
        var response = await commandHandler.HandleAsync(request);
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