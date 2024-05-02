using DongPhuong.Domain.Entities.Features.Drinks;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Enums;

namespace DongPhuong.Infrastructure.Data;

public class DatabaseInitializer
{
    private readonly DataContext _context;

    public DatabaseInitializer(DataContext context)
    {
        _context = context;
    }

    public async Task SeedData()
    {
        if (!_context.Drinks.Any())
        {
            _context.Drinks.AddRange(
                new Drink(DrinkNames.Avocado, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Banana, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Cappucino, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Coconut, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Coffee, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.GreenApple, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Honeydew, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Jackfruit, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Lychee, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Mango, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.MatchaGreenTea, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.MilkTea, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Papaya, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.PassionFruit, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Peach, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Strawberry, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Taro, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.ThaiTea, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.Watermelon, DrinkSizes.Medium, 5.00m),
                new Drink(DrinkNames.RootBeer, DrinkSizes.Medium, 1.50m),
                new Drink(DrinkNames.Coke, DrinkSizes.Medium, 1.50m),
                new Drink(DrinkNames.DietCoke, DrinkSizes.Medium, 1.50m),
                new Drink(DrinkNames.Sprite, DrinkSizes.Medium, 1.50m),
                new Drink(DrinkNames.DrPepper, DrinkSizes.Medium, 1.50m),
                new Drink(DrinkNames.Water, DrinkSizes.Medium, 1.00m),
                new Drink(DrinkNames.HotCoffe, DrinkSizes.Medium, 3.00m),
                new Drink(DrinkNames.IceCoffee, DrinkSizes.Medium, 3.00m),
                new Drink(DrinkNames.IceMilkCoffee, DrinkSizes.Medium, 4.00m),
                new Drink(DrinkNames.HotMilkCoffe, DrinkSizes.Medium, 3.00m),
                new Drink(DrinkNames.LimeadeSoda, DrinkSizes.Medium, 3.00m),
                new Drink(DrinkNames.Limeade, DrinkSizes.Medium, 2.00m),
                new Drink(DrinkNames.EggSoda, DrinkSizes.Medium, 4.00m),
                new Drink(DrinkNames.SoyBeanMilk, DrinkSizes.Medium, 1.75m),
                new Drink(DrinkNames.SaltLimeade, DrinkSizes.Medium, 3.00m),
                new Drink(DrinkNames.UnsweetIceTea, DrinkSizes.Medium, 1.75m),
                new Drink(DrinkNames.HotTea, DrinkSizes.Medium, 1.00m),
                new Drink(DrinkNames.CoconutJuice, DrinkSizes.Medium, 3.00m)
            );
        }

        if (!_context.PreparedGoods.Any())
        {
            _context.PreparedGoods.AddRange(
                new PreparedGood("Chả Giò", "Appetizers", "4 fried shrimp and pork egg rolls", 5.00m),
                new PreparedGood("Gỏi Cuốn", "Appetizers", "2 shrimp & pork spring rolls", 5.00m),
                new PreparedGood("Bún Gà Nướng", "Rice Bowls", "Grilled chicken vermicelli", 11.00m),
                new PreparedGood("Bún Thịt Nướng", "Rice Bowls", "Grilled pork vermicelli", 11.00m),
                new PreparedGood("Bún Nướng", "Rice Bowls", "Grilled beef vermicelli", 11.00m),
                new PreparedGood("Bún Tôm Nướng", "Rice Bowls", "Grilled shrimp vermicelli", 12.50m),
                new PreparedGood("Bún Chả Giò", "Rice Bowls", "Egg roll vermicelli", 11.00m),
                new PreparedGood("Bún Bò Xao", "Rice Bowls", "Lemongrass beef vermicelli", 12.50m),
                new PreparedGood("Bún Nem Nướng", "Rice Bowls", "Vietnamese sausage vermicelli", 11.00m),
                new PreparedGood("Bún Đậu Hủ Nướng", "Rice Bowls", "Grilled tofu vermicelli", 9.00m),
                new PreparedGood("Cơm Suon Nướng", "Rice Bowls", "Grilled pork chop rice bowl", 11.00m),
                new PreparedGood("Cơm Gà Nướng", "Rice Bowls", "Grilled chicken rice bowl", 11.00m),
                new PreparedGood("Cơm Thịt Nướng", "Rice Bowls", "Grilled pork rice bowl", 11.00m),
                new PreparedGood("Cơm Bò Nướng", "Rice Bowls", "Grilled beef rice bowl", 11.00m),
                new PreparedGood("Cơm Tôm Nướng", "Rice Bowls", "Grilled shrimp rice bowl", 13.00m),
                new PreparedGood("Cơm Sườn Đại Hàn", "Rice Bowls", "Korean short ribs rice bowl", 13.00m),
                new PreparedGood("Cơm Đậu Hủ Nướng", "Rice Bowls", "Grilled tofu rice bowl", 11.00m),
                new PreparedGood("Cơm Bì Suon", "Rice Bowls", "Pork chop & shredded pork skin rice bowl", 12.00m),
                new PreparedGood("Cơm Bì Gà", "Rice Bowls", "Chicken & shredded pork skin rice bowl", 12.00m),
                new PreparedGood("Cơm Bì Thịt Nướng", "Rice Bowls", "Pork & shredded pork skin rice bowl", 12.00m),
                new PreparedGood("Cơm Bì Bò Nướng", "Rice Bowls", "Beef & shredded pork skin rice bowl", 12.00m),
                new PreparedGood("Cơm Bì Tôm", "Rice Bowls", "Shrimp & shredded pork skin rice bowl", 15.00m),
                new PreparedGood("Cơm Bì Sườn Đại Hàn", "Rice Bowls", "K-short ribs & shredded pork skin rice bowl",
                    15.00m),
                new PreparedGood("Cơm Bò Luc Lac", "Rice Bowls", "Shaky beef rice bowl", 14.00m),
                new PreparedGood("Bánh Hỏi Gà Nướng", "Rice Bowls", "Grilled chicken vermicelli roll", 14.00m),
                new PreparedGood("Bánh Hỏi Thịt Nướng", "Rice Bowls", "Grilled pork vermicelli roll", 14.00m),
                new PreparedGood("Bánh Hỏi Bò Nướng", "Rice Bowls", "Grilled beef vermicelli roll", 14.00m),
                new PreparedGood("Bánh Hỏi Tôm Nướng", "Rice Bowls", "Grilled shrimp vermicelli roll", 15.00m),
                new PreparedGood("Bánh Hỏi Sườn Đại Hàn", "Rice Bowls", "Korean short ribs vermicelli roll", 15.00m),
                new PreparedGood("Bánh Hỏi Nem Nướng", "Rice Bowls", "Viet sausage vermicelli roll", 12.50m),
                new PreparedGood("Bánh Hỏi Đậu Hủ Nướng", "Rice Bowls", "Grilled tofu vermicelli roll", 12.50m),
                new PreparedGood("Salad Gà Nướng", "Salads", "Grilled chicken salad", 10.00m),
                new PreparedGood("Salad Thịt Nướng", "Salads", "Grilled pork salad", 10.00m),
                new PreparedGood("Salad Bò Nướng", "Salads", "Grilled beef salad", 11.00m),
                new PreparedGood("Salad Tôm Nướng", "Salads", "Grilled shrimp salad", 12.00m),
                new PreparedGood("Salad Chả Giò", "Salads", "Egg roll (bún) salad", 10.00m),
                new PreparedGood("Salad Nem Nướng", "Salads", "Vietnamese sausage salad", 11.00m),
                new PreparedGood("Salad Đậu Hủ Nướng", "Salads", "Grilled tofu salad", 10.00m),
                new PreparedGood("Phở Đặc Biệt", "Soups", "Combination phở", 12.00m),
                new PreparedGood("Phở Chin", "Soups", "Brisket phở", 11.00m),
                new PreparedGood("Phở Tái", "Soups", "Eye of round phở", 11.00m),
                new PreparedGood("Phở Bò Viên", "Soups", "Meatball phở", 11.00m),
                new PreparedGood("Phở Tôm", "Soups", "Shrimp phở", 13.00m),
                new PreparedGood("Phở Rau", "Soups", "Steamed veggies phở", 10.00m),
                new PreparedGood("Phở Nước Lèo", "Soups", "Broth & noodles phở", 9.00m),
                new PreparedGood("Kid’s Phở", "Soups", "Choose any two options", 5.00m),
                new PreparedGood("Bún Bò Huế", "Specialties", "Spicy vermicelli with pork hock & beef", 12.00m),
                new PreparedGood("Bún Riêu", "Specialties", "House special soup with vermicelli, shrimp & fish cake",
                    12.00m),
                new PreparedGood("Hủ Tiếu Satế", "Specialties", "Big flat rice noodle with spicy beef soup", 12.00m),
                new PreparedGood("Hủ Tiếu Dai Hoặc Mì", "Specialties",
                    "Transparent, rice, or egg noodles w pork/seafood in pork broth", 12.00m),
                new PreparedGood("Hủ Tiếu Dai Hoặc Mì Tôm", "Specialties", "Transparent, rice, or egg noodles w shrimp",
                    13.00m),
                new PreparedGood("Hoành Thánh Mì Hoặc Súp", "Specialties",
                    "Egg noodles or soup only w wonton, pork/seafood in pork broth", 13.00m),
                new PreparedGood("Hủ Tiếu Khô Hoặc Mì", "Specialties",
                    "Dry stir fried transparent, rice, or egg noodles w pork/seafood (add wontons for $1)", 13.00m),
                new PreparedGood("Hoành Thánh Mì Khô", "Specialties",
                    "Dry stir fried egg noodles w wonton, pork/seafood", 14.00m)
            );
        }

        if (!_context.PackagedGoods.Any())
        {
            _context.PackagedGoods.AddRange(
                new PackagedGood("Marinated Cooked and Frozen Roast Pork", "Marinated, cooked and Frozen Pork Roast",
                    5.00m, 15.00m),
                new PackagedGood("Marinated Cooked and Frozen Chicken", "Marinated, cooked and frozen chicken", 5.00m,
                    15.00m),
                new PackagedGood("Marinated Cooked and Frozen Beef", "Marinated, cooked and frozen marinated beef ",
                    5.00m, 16.00m),
                new PackagedGood("Marinated Cooked and Frozen Pork Chops", "Marinated, cooked and frozen pork chops",
                    5.00m, 15.00m),
                new PackagedGood("Marinated Raw and Frozen Roast Pork", "Marinated and frozen pork roast", 5.00m,
                    12.00m),
                new PackagedGood("Marinated Raw and Frozen Chicken", "Marinated and frozen chicken", 5.00m, 12.00m),
                new PackagedGood("Marinated Raw and Frozen Beef", "Marinated and frozen beef", 5.00m, 14.00m),
                new PackagedGood("Marinated Raw and Frozen Pork Chops", "Marinated and frozen pork chops", 5.00m,
                    15.00m),
                new PackagedGood("Fish Sauce", "housemade fish sauce", 1.00m, 3.00m),
                new PackagedGood("Peanut Sauce", "housemade peanut sauce", 1.00m, 3.00m)
            );
        }

        await _context.SaveChangesAsync();
    }
}