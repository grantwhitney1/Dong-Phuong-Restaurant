using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Entities.Features.PreparedGoods;

public class PreparedGood : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }

    public PreparedGood()
    {
    }

    public PreparedGood(string name, string category, string description, decimal price)
    {
        Name = name;
        Category = category;
        Description = description;
        Price = price;
    }
}