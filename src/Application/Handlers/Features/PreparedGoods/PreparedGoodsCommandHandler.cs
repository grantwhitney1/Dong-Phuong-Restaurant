using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.PreparedGoods;

public class PreparedGoodsCommandHandler(IRepository<PreparedGood> repository, IMapper mapper) :
    CommandHandler<PreparedGood>(repository, mapper), IPreparedGoodsCommandHandler
{
    public async Task<IPutResponse<PreparedGood>> HandleAsync(IPutRequest<PreparedGood> request)
    {
        throw new NotImplementedException();
    }
}