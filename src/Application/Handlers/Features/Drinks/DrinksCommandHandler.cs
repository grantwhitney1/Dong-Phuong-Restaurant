using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Application.Responses.Features.Base;
using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;

namespace DongPhuong.Application.Handlers.Features.Drinks;

public class DrinksCommandHandler(IDrinksRepository repository) :
    CommandHandler<Drink, DrinkDto>(repository), IDrinksCommandHandler
{
    public async Task<IPutResponse<DrinkDto?>> HandleAsync(int id, IPutRequest<DrinkDto?> request)
    {
        var response = new PutResponse<DrinkDto?>();
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