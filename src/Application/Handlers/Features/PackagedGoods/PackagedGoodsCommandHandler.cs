using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.PackagedGoods;

public class PackagedGoodsCommandHandler(IRepository<PackagedGood> repository) :
    CommandHandler<PackagedGood, PackagedGoodDto>(repository), IPackagedGoodsCommandHandler
{
    public async Task<IPutResponse<PackagedGoodDto>> HandleAsync(IPutRequest<PackagedGoodDto> request)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}