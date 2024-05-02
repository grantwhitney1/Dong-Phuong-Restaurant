using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Entities.Features.Drinks;

public class Drink : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Size { get; set; }
    public decimal? Price { get; set; }

    public Drink()
    {
    }

    public Drink(string name, string category, string size, decimal price)
    {
        Name = name;
        Category = category;
        Size = size;
        Price = price;
    }
}