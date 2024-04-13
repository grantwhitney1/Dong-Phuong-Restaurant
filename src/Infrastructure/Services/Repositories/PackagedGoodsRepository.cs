using AutoMapper;
using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Infrastructure.Data;
using DongPhuong.Infrastructure.Services.Repositories.Base;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

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
    public async Task<IEnumerable<PackagedGoodDto>> GetAllPackagedGoodsAsync(int pageNum = 1, int pageSize = 10, string? filter = null)
    {
        pageNum = pageNum < 1 ? 1 : pageNum;
        pageSize = pageSize < 1 ? 1 : pageSize;

        IQueryable<PackagedGood> query = _dataContext.PackagedGoods;

        // Apply the filter
        if (!string.IsNullOrWhiteSpace(filter))
        {
            query = query.Where(d => d.Name.Contains(filter));
        }

        // Apply paging
        query = query.Skip((pageNum - 1) * pageSize).Take(pageSize);

        var entities = await query.ToListAsync();

        // Map to Dto
        return _mapper.Map<List<PackagedGoodDto>>(entities);
    }
}