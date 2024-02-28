namespace DongPhuong.Domain.Interfaces.Application.Dtos.Features.Drinks;

public interface IDrinkDto
{
    public string? Name { get; set; }
    public string? Size { get; set; }
    public decimal? Price { get; set; }
}