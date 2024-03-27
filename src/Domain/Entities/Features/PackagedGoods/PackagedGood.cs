using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Entities.Features.PackagedGoods;

public class PackagedGood : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Price { get; set; }
    
    public PackagedGood()
    { }

    public PackagedGood(string name, string description, decimal weight, decimal price)
    {
        Name = name;
        Description = description;
        Weight = weight;
        Price = price;
    }
}