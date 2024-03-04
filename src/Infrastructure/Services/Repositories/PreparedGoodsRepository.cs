using AutoMapper;
using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Infrastructure.Data;
using DongPhuong.Infrastructure.Services.Repositories.Base;
using Microsoft.Extensions.Logging;

namespace DongPhuong.Infrastructure.Services.Repositories;

public class PreparedGoodsRepository(DataContext dataContext, ILogger<PreparedGoodsRepository> logger, IMapper mapper) :
    Repository<PreparedGood>(dataContext, logger, mapper), IPreparedGoodsRepository
{
    private readonly IMapper _mapper = mapper;
    private readonly DataContext _dataContext = dataContext;

    public async Task<PreparedGoodDto?> UpdateAsync(int id, PreparedGoodDto dto)
    {
        var entity = await GetAsync(id);
        if (entity is null)
            return null;
        _mapper.Map(dto, entity);
        _dataContext.Update(entity);
        await SaveAsync();
        return dto;
    }
}