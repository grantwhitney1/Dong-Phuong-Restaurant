using Microsoft.EntityFrameworkCore;

namespace DongPhuong.Infrastructure.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options);