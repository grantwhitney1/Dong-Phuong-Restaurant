using DongPhuong.Domain.Interfaces.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Entities;

public interface IDrink : IDrinkDto;

public interface IDrinkDto : IDrinkQueryDto;

public interface IDrinkQueryDto : IEntity, IDrinkCommandDto;

public interface IDrinkCommandDto
{
    public string? Name { get; set; }
    public string? Size { get; set; }
    public decimal Price { get; set; }
}