using DongPhuong.Domain.Interfaces.Entities.Features.PackagedGoods;

namespace DongPhuong.Domain.Entities.Features.PackagedGoods;

public class PackagedGood : IPackagedGood
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Price { get; set; }
}