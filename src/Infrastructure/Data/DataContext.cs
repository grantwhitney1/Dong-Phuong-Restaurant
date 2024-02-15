using DongPhuong.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DongPhuong.Infrastructure.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public virtual required DbSet<PackagedGood> PackagedGoods { get; init; }
}