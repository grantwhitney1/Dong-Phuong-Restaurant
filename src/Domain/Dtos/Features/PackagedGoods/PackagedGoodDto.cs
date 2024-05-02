using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Domain.Dtos.Features.PackagedGoods;

public class PackagedGoodDto : IDto
{
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Price { get; set; }
}