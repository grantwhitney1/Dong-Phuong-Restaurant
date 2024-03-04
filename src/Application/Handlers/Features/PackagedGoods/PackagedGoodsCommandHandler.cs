using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Application.Responses.Features.Base;
using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;

namespace DongPhuong.Application.Handlers.Features.PackagedGoods;

public class PackagedGoodsCommandHandler(IPackagedGoodsRepository repository) :
    CommandHandler<PackagedGood, PackagedGoodDto>(repository), IPackagedGoodsCommandHandler
{
    public async Task<IPutResponse<PackagedGoodDto?>> HandleAsync(int id, IPutRequest<PackagedGoodDto?> request)
    {
        var response = new PutResponse<PackagedGoodDto?>();
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