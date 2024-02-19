namespace DongPhuong.Application.Dtos;

public class PreparedGoodDto : PreparedGoodQueryDto
{
    
}

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