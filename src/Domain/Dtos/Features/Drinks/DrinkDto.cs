using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Domain.Dtos.Features.Drinks;

public class DrinkDto : IDto
{
    public string? Name { get; set; }
    public string? Size { get; set; }
    public decimal? Price { get; set; }
}