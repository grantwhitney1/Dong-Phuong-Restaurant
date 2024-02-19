using DongPhuong.Domain.Interfaces.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Entities;

public interface IPreparedGood : IPreparedGoodDto;

public interface IPreparedGoodDto : IEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}