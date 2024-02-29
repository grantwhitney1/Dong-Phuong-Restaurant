using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.PreparedGoods;

public class PreparedGoodsCommandHandler(IRepository<PreparedGood> repository) :
    CommandHandler<PreparedGood, PreparedGoodDto>(repository), IPreparedGoodsCommandHandler
{
    public async Task<IPutResponse<PreparedGoodDto>> HandleAsync(IPutRequest<PreparedGoodDto> request)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}