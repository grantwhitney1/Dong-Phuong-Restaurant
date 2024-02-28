using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

namespace DongPhuong.Application.Handlers.Features.Base;

public class BaseQueryHandler : IBaseQueryHandler
{
    public async Task<TEntity> Get<TEntity>(IBaseGetRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<TEntity>> GetAll<TEntity>(IBaseGetRequest request)
    {
        throw new NotImplementedException();
    }
}