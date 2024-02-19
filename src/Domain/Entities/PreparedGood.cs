using DongPhuong.Domain.Interfaces.Entities;

namespace DongPhuong.Domain.Entities;

public class PreparedGood : IPreparedGood
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}