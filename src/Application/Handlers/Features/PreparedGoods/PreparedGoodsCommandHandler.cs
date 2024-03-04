using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Application.Responses.Features.Base;
using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;

namespace DongPhuong.Application.Handlers.Features.PreparedGoods;

public class PreparedGoodsCommandHandler(IPreparedGoodsRepository repository) :
    CommandHandler<PreparedGood, PreparedGoodDto>(repository), IPreparedGoodsCommandHandler
{
    public async Task<IPutResponse<PreparedGoodDto?>> HandleAsync(int id, IPutRequest<PreparedGoodDto?> request)
    {
        var response = new PutResponse<PreparedGoodDto?>();
        if (request.Dto is null)
        {
            response.Errors = response.Errors.Append("The request body cannot contain null members.");
            return response;
        }
        response.Dto = await repository.UpdateAsync(id, request.Dto);
        if (response.Dto is null)
            response.Errors = response.Errors.Append("The requested entity was not found in the database.");
        return response;
    }
}