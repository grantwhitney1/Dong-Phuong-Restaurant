using DongPhuong.Domain.Interfaces.Domain.Entities;

namespace DongPhuong.Domain.Entities.Features.PreparedGoods;

public class PreparedGood : IPreparedGood
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}