using System.Reflection;
using Microsoft.EntityFrameworkCore;
using DongPhuong.Domain.Entities.Features.PackagedGoods;
using DongPhuong.Domain.Entities.Features.Drinks;  
using DongPhuong.Domain.Entities.Features.PreparedGoods;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DongPhuong.Infrastructure.Data
{

    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Drink> Drinks { get; set; }   
        public DbSet<PreparedGood> PreparedGoods { get; set; } // Add this line
        public DbSet<PackagedGood> PackagedGoods { get; set; } // Add this line

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PackagedGood).GetTypeInfo().Assembly);
        }
    }
}