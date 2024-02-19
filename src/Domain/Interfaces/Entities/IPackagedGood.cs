using DongPhuong.Domain.Interfaces.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Entities;

public interface IPackagedGood : IPackagedGoodDto;

public interface IPackagedGoodDto : IPackagedGoodQueryDto;

public interface IPackagedGoodQueryDto : IEntity, IPackagedGoodCommandDto;

public interface IPackagedGoodCommandDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Weight { get; set; }
    public decimal Price { get; set; }
}