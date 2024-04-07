using DongPhuong.Domain.Dtos.Features.PreparedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.PreparedGoods;

public interface IPreparedGoodsQueryHandler : IQueryHandler
{
    Task<IEnumerable<PreparedGoodDto>> HandleGetPreparedGoodsPagedAsync(int pageNum, int pageSize, string filter);
}