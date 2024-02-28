using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Entities.Features.Drinks;

public class Drink : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Size { get; set; }
    public decimal? Price { get; set; }
}