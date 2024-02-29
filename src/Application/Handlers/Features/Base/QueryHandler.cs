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

public class QueryHandler<TEntity>(IRepository<TEntity> repository, IMapper mapper)
    : IQueryHandler where TEntity : class, IEntity
{
    public async Task<IGetResponse<TDto>> HandleAsync<TDto>(IGetRequest<TDto> request) where TDto : class, IDto
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task<IGetResponse<TDto>> HandleAsync<TDto>(int id) where TDto : class, IDto
    {
        return new GetResponse<TDto>
        {
            Data = [await repository.GetAsync(id)]
        };
    }

    public async Task<IGetResponse<TDto>> HandleAsync<TDto>() where TDto : class, IDto
    {
        return new GetResponse<TDto>
        {
            Data = await repository.GetAll()
                .Select(x => mapper.Map<TDto>(x))
                .ToListAsync()
        };
    }
}