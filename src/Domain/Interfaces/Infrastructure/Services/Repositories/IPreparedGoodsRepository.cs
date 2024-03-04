using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;

public interface IPreparedGoodsRepository : IRepository<PreparedGood>
{
    public Task<PreparedGoodDto?> UpdateAsync(int id, PreparedGoodDto dto);
}