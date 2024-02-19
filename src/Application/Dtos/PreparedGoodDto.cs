using DongPhuong.Domain.Interfaces.Entities;

namespace DongPhuong.Application.Dtos;

public class PreparedGoodDto : PreparedGoodQueryDto, IPreparedGoodDto;

public class PreparedGoodQueryDto : PreparedGoodCommandDto
{
    public int Id { get; set; }
}

public class PreparedGoodCommandDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}