namespace DongPhuongRestaurant.Application.Dtos
{
    public class DrinkDto
    {
        public DrinkQueryDto DrinkQueryDto { get; set; }
        public DrinkCommandDto DrinkCommandDto { get; set; }
    }

    public class DrinkQueryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }

    public class DrinkCommandDto
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }
}