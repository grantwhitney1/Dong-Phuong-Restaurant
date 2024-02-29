using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Presentation.Controllers.Api.Base;
using Microsoft.AspNetCore.Mvc;

namespace DongPhuong.Presentation.Controllers.Api;

[Route("api/[controller]")]
public class PreparedGoodsController(IPreparedGoodsCommandHandler commandHandler, IPreparedGoodsQueryHandler queryHandler) : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await queryHandler.HandleAsync<PreparedGoodGetDto>());
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id) =>
        Ok(await queryHandler.HandleAsync<PreparedGoodGetDto>(id));
}