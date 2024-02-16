using System.Reflection;
using Microsoft.EntityFrameworkCore;
using DongPhuong.Domain.Entities;

namespace DongPhuong.Infrastructure.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PackagedGood).GetTypeInfo().Assembly);
    }
}