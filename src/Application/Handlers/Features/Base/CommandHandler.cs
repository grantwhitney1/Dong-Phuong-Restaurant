using AutoMapper;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Application.Handlers.Features.Base;

public class CommandHandler<TEntity>(IRepository<TEntity> repository, IMapper mapper) :
    ICommandHandler<TEntity> where TEntity : class, IEntity
{
    public async Task<IPostResponse<TEntity>> HandleAsync(IPostRequest<TEntity> request)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task<IDeleteResponse<TEntity>> HandleAsync(IDeleteRequest<TEntity> request)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}