using DongPhuong.Domain.Interfaces.Domain.Entities;

namespace DongPhuong.Domain.Entities.Features.Drinks;

public class Drink : IDrink
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Size { get; set; }
    public decimal? Price { get; set; }
}