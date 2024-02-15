namespace DongPhuong.Application.Dtos;

public class PackagedGoodDto : PackagedGoodQueryDto
{
    
}

public class PackagedGoodQueryDto : PackagedGoodCommandDto
{
    public int Id { get; set; }
}

public class PackagedGoodCommandDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Weight { get; set; }
    public decimal Price { get; set; }
}