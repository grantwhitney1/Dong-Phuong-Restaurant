using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

public interface ICommandHandler<TEntity, TDto>
    where TDto : class, IDto
    where TEntity : class, IEntity
{
    public Task<IPostResponse<TDto>> HandleAsync(IPostRequest<TDto> request);
    public Task<IDeleteResponse<TDto>> HandleAsync(int id);
}