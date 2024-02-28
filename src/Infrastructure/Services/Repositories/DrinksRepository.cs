using AutoMapper;
using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Infrastructure.Data;
using DongPhuong.Infrastructure.Services.Repositories.Base;
using Microsoft.Extensions.Logging;

namespace DongPhuong.Infrastructure.Services.Repositories;

public class DrinksRepository(DataContext dataContext, ILogger logger, IMapper mapper) :
    Repository<Drink>(dataContext, logger, mapper), IDrinksRepository
{
    private readonly DataContext _dataContext = dataContext;
    private readonly IMapper _mapper = mapper;

    public async Task<Drink?> UpdateAsync(int id, DrinkDto dto)
    {
        var entity = await GetAsync(id);
        if (entity is null)
            return entity;
        _mapper.Map(dto, entity);
        _dataContext.Update(entity);
        await SaveAsync();
        return entity;
    }
}