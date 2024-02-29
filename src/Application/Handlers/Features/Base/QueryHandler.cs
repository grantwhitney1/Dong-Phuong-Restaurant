using AutoMapper;
using AutoMapper.QueryableExtensions;
using DongPhuong.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace DongPhuong.Application.Handlers.Features.Base;

public class QueryHandler<TEntity>(IRepository<TEntity> repository, IMapper mapper) : IQueryHandler<TEntity> where TEntity : class, IEntity
{
    public async Task<IGetResponse<TEntity>> HandleAsync<TDto>(IGetRequest<TEntity> request) where TDto : class, IDto
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task<IGetResponse<TEntity>> HandleAsync<TDto>(int id) where TDto : class, IDto =>
        new GetResponse<TEntity>
        {
            Data = [await repository.GetAsync(id)]
        };

    public async Task<IGetResponse<TEntity>> HandleAsync<TDto>() where TDto : class, IDto =>
        new GetResponse<TEntity>
        {
            Data = await repository.GetAll()
                .ProjectTo<TDto>(mapper.ConfigurationProvider)
                .ToListAsync()
        };
}