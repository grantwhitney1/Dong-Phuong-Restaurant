using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;

public interface IPreparedGoodsCommandHandler : ICommandHandler<PreparedGood, PreparedGoodDto>
{
    public Task<IPutResponse<PreparedGoodDto?>> HandleAsync(int id, IPutRequest<PreparedGoodDto?> request);
}