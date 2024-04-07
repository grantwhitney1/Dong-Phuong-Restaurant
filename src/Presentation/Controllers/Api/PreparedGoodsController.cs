using DongPhuong.Application.Requests.Features.Base;
using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Presentation.Controllers.Api.Base;
using Microsoft.AspNetCore.Mvc;

namespace DongPhuong.Presentation.Controllers.Api;

[Route("api/[controller]")]
public class PreparedGoodsController(
    IPreparedGoodsCommandHandler commandHandler,
    IPreparedGoodsQueryHandler queryHandler) : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await queryHandler.HandleAsync<PreparedGoodGetDto>());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        return Ok(await queryHandler.HandleAsync<PreparedGoodGetDto>(id));
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PostRequest<PreparedGoodDto> request)
    {
        var response = await commandHandler.HandleAsync(request);
        if (response.Errors.Any())
            return BadRequest(response);
        return Ok(response);
    }
    
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PutRequest<PreparedGoodDto?> request)
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
    [HttpGet("paged")]
    public async Task<IActionResult> GetPaged([FromQuery] int pageNum = 1, [FromQuery] int pageSize = 10, [FromQuery] string filter = null)
    {
        var preparedGoods = await queryHandler.HandleGetPreparedGoodsPagedAsync(pageNum, pageSize, filter);
        return Ok(preparedGoods);
    }
}