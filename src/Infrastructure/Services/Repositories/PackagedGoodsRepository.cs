using AutoMapper;
using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Infrastructure.Data;
using DongPhuong.Infrastructure.Services.Repositories.Base;
using Microsoft.Extensions.Logging;

namespace DongPhuong.Infrastructure.Services.Repositories;

public class PackagedGoodsRepository(DataContext dataContext, ILogger<PackagedGoodsRepository> logger, IMapper mapper) :
    Repository<PackagedGood>(dataContext, logger, mapper), IPackagedGoodsRepository
{
    private readonly DataContext _dataContext = dataContext;
    private readonly IMapper _mapper = mapper;

    public async Task<PackagedGoodDto?> UpdateAsync(int id, PackagedGoodDto dto)
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