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

        builder.Property(x => x.Description)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Price)
            .HasPrecision(precisionPrice, scalePrice);

        builder.Property(x => x.Weight)
            .HasPrecision(precisionWeight, scaleWeight);

        builder.HasData(
            new PackagedGood("Marinated Cooked and Frozen Roast Pork", "cooked and frozen pork roast", 5.00m, 18.00m),
            new PackagedGood("Marinated Cooked and Frozen Chicken", "cooked and frozen chicken", 5.00m, 16.00m),
            new PackagedGood("Marinated Cooked and Frozen Beef", "cooked and frozen marinated beef ", 5.00m, 18.00m),
            new PackagedGood("Marinated Cooked and Frozen Pork Chops", "cooked and frozen pork chops", 5.00m, 22.00m),
            new PackagedGood("Marinated Raw and Frozen Roast Pork", "raw and frozen pork roast", 5.00m, 16.00m),
            new PackagedGood("Marinated Raw and Frozen Chicken", "raw and frozen chicken", 5.00m, 15.00m),
            new PackagedGood("Marinated Raw and Frozen Beef", "raw and frozen beef", 5.00m, 15.00m),
            new PackagedGood("Marinated Raw and Frozen Pork Chops", "raw and frozen pork chops", 5.00m, 18.00m),
            new PackagedGood("Fish Sauce", "housemade fish sauce", 1.00m, 3.00m),
            new PackagedGood("Peanut Sauce", "housemade peanut sauce", 1.00m, 3.00m)
        );
    }
}