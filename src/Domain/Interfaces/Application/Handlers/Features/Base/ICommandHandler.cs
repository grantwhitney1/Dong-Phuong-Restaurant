using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

public interface ICommandHandler<TEntity> where TEntity : class, IEntity
{
    public Task<IPostResponse<TEntity>> HandleAsync(IPostRequest<TEntity> request);
    public Task<IDeleteResponse<TEntity>> HandleAsync(IDeleteRequest<TEntity> request);
}