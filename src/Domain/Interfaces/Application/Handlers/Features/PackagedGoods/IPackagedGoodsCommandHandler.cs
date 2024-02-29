using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;

public interface IPackagedGoodsCommandHandler : ICommandHandler<PackagedGood>
{
    public Task<IPutResponse<PackagedGood>> HandleAsync(IPutRequest<PackagedGood> request);
}