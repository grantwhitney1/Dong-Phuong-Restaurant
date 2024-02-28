namespace DongPhuong.Domain.Interfaces.Application.Dtos.Features.PreparedGoods;

public interface IPreparedGoodDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}