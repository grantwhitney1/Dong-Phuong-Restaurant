using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

namespace DongPhuong.Application.Handlers.Features.Base;

public class BaseCommandHandler : IBaseCommandHandler
{
    public async Task<TEntity> Create<TEntity>(IBasePostRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> Update<TEntity>(IBasePutRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task Delete<TEntity>(IBaseDeleteRequest request)
    {
        throw new NotImplementedException();
    }
}