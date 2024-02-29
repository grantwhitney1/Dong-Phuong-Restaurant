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
    public async Task<PreparedGood?> UpdateAsync(int id, PreparedGoodDto dto)
    {
        throw new NotImplementedException();
    }
}