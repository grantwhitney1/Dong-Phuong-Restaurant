using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;
using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;

namespace DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;

    public interface IPreparedGoodsRepository : IRepository<PreparedGood>
    {
        Task<PreparedGoodDto?> UpdateAsync(int id, PreparedGoodDto dto);
        Task<IEnumerable<PreparedGoodDto>> GetAllPreparedGoodsAsync(int pageNum = 1, int pageSize = 10, string? filter = null);
    }
