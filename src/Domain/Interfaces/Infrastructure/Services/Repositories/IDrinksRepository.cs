using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories
{
    public interface IDrinksRepository : IRepository<Drink>
    {
        Task<DrinkDto?> UpdateAsync(int id, DrinkDto dto);
        Task<IEnumerable<DrinkDto>> GetAllDrinksAsync(int pageNum = 1, int pageSize = 10, string filter = null);
    }
}