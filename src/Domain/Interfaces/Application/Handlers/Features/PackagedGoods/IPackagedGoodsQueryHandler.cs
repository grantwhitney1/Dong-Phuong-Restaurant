using DongPhuong.Domain.Dtos.Features.PackagedGoods;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.PackagedGoods;

public interface IPackagedGoodsQueryHandler : IQueryHandler
{
Task<IEnumerable<PackagedGoodDto>> HandleGetPackagedGoodsPagedAsync(int pageNum, int pageSize, string filter);
}