namespace DongPhuong.Domain.Interfaces.Entities.Features.Drinks;

public interface IDrinkDto
{
    public string? Name { get; set; }
    public string? Size { get; set; }
    public decimal? Price { get; set; }
}