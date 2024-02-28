using AutoMapper;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;
using DongPhuong.Infrastructure.Data;

namespace DongPhuong.Application.Handlers.Features.Base;

public class BaseCommandHandler(DataContext dataContext, IMapper mapper) : IBaseCommandHandler
{
    public async Task HandleAsync<TEntity, TDto>(TDto dto)
        where TEntity : class, IEntity
        where TDto : class
    {
        throw new NotImplementedException();
    }
}