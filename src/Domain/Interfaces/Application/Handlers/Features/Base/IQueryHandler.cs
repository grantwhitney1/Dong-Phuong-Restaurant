using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

public interface IQueryHandler<TEntity> where TEntity : class, IEntity
{
    public Task<IGetResponse<TEntity>> HandleAsync<TDto>(IGetRequest<TEntity> request) where TDto : class, IDto;
    public Task<IGetResponse<TEntity>> HandleAsync<TDto>(int id) where TDto : class, IDto;
    public Task<IGetResponse<TEntity>> HandleAsync<TDto>() where TDto : class, IDto;
}