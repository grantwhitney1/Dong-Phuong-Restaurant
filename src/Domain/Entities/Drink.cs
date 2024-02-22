using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Extensions;
using DongPhuong.Domain.Interfaces.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DongPhuong.Domain.Entities;

public class Drink : IDrink
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Size { get; set; }
    public decimal Price { get; set; }
}

public class DrinkEntityConfiguration : IEntityTypeConfiguration<Drink>
{
    public void Configure(EntityTypeBuilder<Drink> builder)
    {
        // lengths
        const int maxBaseString = (int)Max.BaseString;
        // precision
        const int precisionPrice = (int)Precision.Price;
        // scale
        const int scalePrice = (int)Scale.Price;

        builder.ToTable(nameof(Drink).ToPlural(), Schemas.Domain);

        builder.Property(x => x.Name)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Size)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Price)
            .HasPrecision(precisionPrice, scalePrice);

    }
}