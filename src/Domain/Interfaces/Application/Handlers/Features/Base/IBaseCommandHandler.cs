using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

public interface IBaseCommandHandler
{
    public Task<TEntity> Create<TEntity>(IBasePostRequest request);
    public Task<TEntity> Update<TEntity>(IBasePutRequest request);
    public Task Delete<TEntity>(IBaseDeleteRequest request);
}