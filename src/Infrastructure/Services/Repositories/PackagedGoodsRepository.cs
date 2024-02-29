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
    public async Task<PackagedGood?> UpdateAsync(int id, PackagedGoodDto dto)
    {
        throw new NotImplementedException();
    }
}