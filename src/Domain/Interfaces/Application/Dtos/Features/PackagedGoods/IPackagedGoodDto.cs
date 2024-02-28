namespace DongPhuong.Domain.Interfaces.Application.Dtos.Features.PackagedGoods;

public interface IPackagedGoodDto
{
    public string? Name { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Price { get; set; }
}