using AutoMapper;
using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;
using DongPhuong.Infrastructure.Data;
using DongPhuong.Infrastructure.Services.Repositories.Base;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

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
    public async Task<IEnumerable<PreparedGoodDto>> GetAllPreparedGoodsAsync(int pageNum = 1, int pageSize = 10, string filter = null)
    {
        pageNum = pageNum < 1 ? 1 : pageNum;
        pageSize = pageSize < 1 ? 1 : pageSize;

        IQueryable<PreparedGood> query = _dataContext.PreparedGoods;

        // Apply the filter
        if (!string.IsNullOrWhiteSpace(filter))
        {
            query = query.Where(d => d.Description.Contains(filter));
        }

        // Apply paging
        query = query.Skip((pageNum - 1) * pageSize).Take(pageSize);

        var entities = await query.ToListAsync();

        // Map to Dto
        return _mapper.Map<List<PreparedGoodDto>>(entities);
    }
}