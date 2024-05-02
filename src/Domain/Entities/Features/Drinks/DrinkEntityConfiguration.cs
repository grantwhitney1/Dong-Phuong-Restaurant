using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DongPhuong.Domain.Entities.Features.Drinks;

public class DrinkEntityConfiguration : IEntityTypeConfiguration<Drink>
{
    public void Configure(EntityTypeBuilder<Drink> builder)
    {
        const int maxBaseString = (int)Max.BaseString;
        const int precisionPrice = (int)Precision.Price;
        const int scalePrice = (int)Scale.Price;

        builder.ToTable(nameof(Drink).ToPlural(), Schemas.Domain);

        builder.Property(x => x.Name)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Category)
            .HasMaxLength(maxBaseString)
            .IsRequired();

        builder.Property(x => x.Size)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Price)
            .HasPrecision(precisionPrice, scalePrice);
    }
}