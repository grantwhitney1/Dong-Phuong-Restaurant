using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DongPhuong.Domain.Entities.Features.PackagedGoods;

public class PackagedGoodEntityConfiguration : IEntityTypeConfiguration<PackagedGood>
{
    public void Configure(EntityTypeBuilder<PackagedGood> builder)
    {
        const int maxBaseString = (int)Max.BaseString;
        const int precisionPrice = (int)Precision.Price;
        const int precisionWeight = (int)Precision.Weight;
        const int scalePrice = (int)Scale.Price;
        const int scaleWeight = (int)Scale.Weight;

        builder.ToTable(nameof(PackagedGood).ToPlural(), Schemas.Domain);

        builder.Property(x => x.Name)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Category)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Description)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Price)
            .HasPrecision(precisionPrice, scalePrice);

        builder.Property(x => x.Weight)
            .HasPrecision(precisionWeight, scaleWeight);
    }
}