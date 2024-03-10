using System.Reflection;
using Microsoft.EntityFrameworkCore;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
            new PreparedGood { Id = 10, Name = "bún đậu hủ nướng", Description = "grilled tofu vermicelli", Price = 9.00m }
        );
    }
}

