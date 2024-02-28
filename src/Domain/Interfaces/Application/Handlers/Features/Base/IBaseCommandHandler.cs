using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

public interface IBaseCommandHandler
{
    public Task HandleAsync<TEntity, TDto>(TDto dto)
        where TEntity : class, IEntity
        where TDto : class;
}