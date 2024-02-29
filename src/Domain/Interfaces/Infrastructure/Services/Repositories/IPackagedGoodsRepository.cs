using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;

public interface IPackagedGoodsRepository : IRepository<PackagedGood>
{
    public Task<PackagedGood?> UpdateAsync(int id, PackagedGoodDto dto);
}