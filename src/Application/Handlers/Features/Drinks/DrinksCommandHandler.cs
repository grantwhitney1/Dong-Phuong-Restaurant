using AutoMapper;
using DongPhuong.Application.Handlers.Features.Base;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.Drinks;

public class DrinksCommandHandler(IRepository<Drink> repository, IMapper mapper) :
    CommandHandler<Drink>(repository, mapper), IDrinksCommandHandler
{
    public async Task<IPutResponse<Drink>> HandleAsync(IPutRequest<Drink> request)
    {
        throw new NotImplementedException();
    }
}