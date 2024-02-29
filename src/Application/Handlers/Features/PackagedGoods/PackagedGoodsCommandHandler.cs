using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.PackagedGoods;

public class PackagedGoodsCommandHandler(IRepository<PackagedGood> repository, IMapper mapper) :
    CommandHandler<PackagedGood>(repository, mapper), IPackagedGoodsCommandHandler
{
    public async Task<IPutResponse<PackagedGood>> HandleAsync(IPutRequest<PackagedGood> request)
    {
        throw new NotImplementedException();
    }
}