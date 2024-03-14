using System.Reflection;
using Microsoft.EntityFrameworkCore;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DongPhuong.Domain.Entities.Features.Drinks;

namespace DongPhuong.Infrastructure.Data;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<IdentityUser>(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PackagedGood).GetTypeInfo().Assembly);
        modelBuilder.Entity<PreparedGood>().HasData(
            new PreparedGood { Id = 1, Name = "chả giò", Description = "4 fried shrimp & pork egg rolls", Price = 5.00m },
            new PreparedGood { Id = 2, Name = "gỏi cuốn", Description = "2 shrimp & pork spring rolls", Price = 5.00m },
            new PreparedGood { Id = 3, Name = "bún gà nướng", Description = "grilled chicken vermicelli", Price = 11.00m },
            new PreparedGood { Id = 4, Name = "bún thịt nướng", Description = "grilled pork vermicelli", Price = 11.00m },
            new PreparedGood { Id = 5, Name = "bún nướng", Description = "grilled beef vermicelli", Price = 11.00m },
            new PreparedGood { Id = 6, Name = "bún tôm nướng", Description = "grilled shrimp vermicelli", Price = 12.50m },
            new PreparedGood { Id = 7, Name = "bún chả giò", Description = "egg roll vermicelli", Price = 11.00m },
            new PreparedGood { Id = 8, Name = "bún bò xao", Description = "lemon grass beef vermicelli", Price = 12.50m },
            new PreparedGood { Id = 9, Name = "bún nem nướng", Description = "vietnamese sausage vermicelli", Price = 11.00m },
            new PreparedGood { Id = 10, Name = "bún đậu hủ nướng", Description = "grilled tofu vermicelli", Price = 9.00m },
            new PreparedGood { Id = 11, Name = "cơm suon nướng", Description = "grilled pork chop", Price = 11.00m },
            new PreparedGood { Id = 12, Name = "cơm gà nướng", Description = "grilled chicken", Price = 11.00m },
            new PreparedGood { Id = 13, Name = "cơm thịt nướng", Description = "grilled pork", Price = 11.00m },
            new PreparedGood { Id = 14, Name = "cơm bò nướng", Description = "grilled beef", Price = 11.00m },
            new PreparedGood { Id = 15, Name = "cơm tôm nướng", Description = "grilled shrimp", Price = 13.00m },
            new PreparedGood { Id = 16, Name = "cơm sườn đại hàn", Description = "korean short ribs", Price = 13.00m },
            new PreparedGood { Id = 17, Name = "cơm đậu hủ nướng", Description = "grilled tofu", Price = 11.00m },
            new PreparedGood { Id = 18, Name = "cơm bì suon", Description = "pork chop & shredded pork skin", Price = 12.00m },
            new PreparedGood { Id = 19, Name = "bánh hỏi gà nướng", Description = "grilled chicken vermicelli roll", Price = 14.00m },
            new PreparedGood { Id = 20, Name = "bánh hỏi thịt nướng", Description = "grilled pork vermicelli roll", Price = 14.00m },
            new PreparedGood { Id = 21, Name = "bánh hỏi bò nướng", Description = "grilled beef vermicelli roll", Price = 14.00m },
            new PreparedGood { Id = 22, Name = "bánh hỏi tôm nướng", Description = "grilled shrimp vermicelli roll", Price = 15.00m },
            new PreparedGood { Id = 23, Name = "bánh hỏi sườn đại hàn", Description = "korean short ribs vermicelli roll", Price = 15.00m },
            new PreparedGood { Id = 24, Name = "bánh hỏi nem nướng", Description = "viet sausage vermicelli roll", Price = 12.50m },
            new PreparedGood { Id = 25, Name = "bánh hỏi đậu hủ nướng", Description = "grilled tofu vermicelli roll", Price = 12.50m },
            new PreparedGood { Id = 26, Name = "phở đặc biệt", Description = "combination pho", Price = 12.00m },
            new PreparedGood { Id = 27, Name = "phở chin", Description = "brisket pho", Price = 11.00m },
            new PreparedGood { Id = 28, Name = "phở tái", Description = "eye of round pho", Price = 11.00m },
            new PreparedGood { Id = 29, Name = "phở bò viên", Description = "meatball pho", Price = 11.00m },
            new PreparedGood { Id = 30, Name = "phở tôm", Description = "shrimp pho", Price = 13.00m },
            new PreparedGood { Id = 31, Name = "phở rau", Description = "steamed veggies pho", Price = 10.00m },
            new PreparedGood { Id = 32, Name = "phở nước lèo", Description = "broth & noodles pho", Price = 9.00m },
            new PreparedGood { Id = 33, Name = "kids phở", Description = "any pho option", Price = 5.00m },
            new PreparedGood { Id = 34, Name = "salad gà nướng", Description = "grilled chicken", Price = 10.00m },
            new PreparedGood { Id = 35, Name = "salad thịt nướng", Description = "grilled pork", Price = 10.00m },
            new PreparedGood { Id = 36, Name = "salad bò nướng", Description = "grilled beef", Price = 11.00m },
            new PreparedGood { Id = 37, Name = "salad tôm nướng", Description = "grilled shrimp", Price = 12.00m },
            new PreparedGood { Id = 38, Name = "salad chả giò", Description = "egg roll (bún)", Price = 10.00m },
            new PreparedGood { Id = 39, Name = "salad nem nướng", Description = "vietnamese sausage", Price = 11.00m },
            new PreparedGood { Id = 40, Name = "salad đậu hủ nướng", Description = "grilled tofu", Price = 10.00m }
        );
        modelBuilder.Entity<Drink>().HasData(
            new Drink { Id = 1, Name = "Avocado Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 2, Name = "Banana Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 3, Name = "Cappucino Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 4, Name = "Coconut Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 5, Name = "Coffee Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 6, Name = "Green Apple Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 7, Name = "Honeydew Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 8, Name = "Jackfruit Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 9, Name = "Lychee Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 10, Name = "Mango Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 11, Name = "Matcha Green Tea Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 12, Name = "Milk Tea Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 13, Name = "Papaya Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 14, Name = "Passion Fruit Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 15, Name = "Peach Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 16, Name = "Strawberry Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 17, Name = "Taro Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 18, Name = "Thai Tea Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 19, Name = "Watermelon Tapioca", Size = "Medium", Price = 5.00m },
            new Drink { Id = 20, Name = "Coke", Size = "Medium", Price = 3.00m },
            new Drink { Id = 21, Name = "Sprite", Size = "Medium", Price = 3.00m },
            new Drink { Id = 22, Name = "Dr. Pepper", Size = "Medium", Price = 3.00m },
            new Drink { Id = 23, Name = "Root Beer", Size = "Medium", Price = 3.00m },
            new Drink { Id = 24, Name = "Water", Size = "Medium", Price = 0.00m },
            new Drink { Id = 25, Name = "Tea", Size = "Medium", Price = 3.00m },
            new Drink { Id = 26, Name = "Lemonade", Size = "Medium", Price = 3.00m },
            new Drink { Id = 27, Name = "Coffee", Size = "Medium", Price = 3.00m }
        );
    }
}

