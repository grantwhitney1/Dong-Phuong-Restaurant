using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.Drinks;

public class DrinksCommandHandler(IRepository<Drink> repository) :
    CommandHandler<Drink, DrinkDto>(repository), IDrinksCommandHandler
{
    public async Task<IPutResponse<DrinkDto>> HandleAsync(IPutRequest<DrinkDto> request)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}