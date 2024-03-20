using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Entities.Features.PreparedGoods;

public class PreparedGood : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }

    public PreparedGood(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}