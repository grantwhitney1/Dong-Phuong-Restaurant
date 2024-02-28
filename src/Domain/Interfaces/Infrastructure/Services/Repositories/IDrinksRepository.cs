using DongPhuong.Domain.Dtos.Features.Drinks;
using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

namespace DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories;

public interface IDrinksRepository : IRepository<Drink>
{
    public Task<Drink?> UpdateAsync(int id, DrinkDto dto);
}