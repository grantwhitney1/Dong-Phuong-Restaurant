using DongPhuong.Domain.Dtos.Features.Drinks;
using System.Collections.Generic;
using System.Threading.Tasks;
using DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Drinks
{
    public interface IDrinksQueryHandler : IQueryHandler
    {
        Task<IEnumerable<DrinkDto>> HandleGetDrinksPagedAsync(int pageNum, int pageSize, string filter);
    }
}