using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

public interface IBaseQueryHandler
{
    public Task<TEntity> Get<TEntity>(IBaseGetRequest request);
    public Task<IEnumerable<TEntity>> GetAll<TEntity>(IBaseGetRequest request);
}