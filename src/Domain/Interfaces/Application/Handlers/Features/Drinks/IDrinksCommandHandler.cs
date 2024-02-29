using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks;

public interface IDrinksCommandHandler : ICommandHandler<Drink>
{
    public Task<IPutResponse<Drink>> HandleAsync(IPutRequest<Drink> request);
}