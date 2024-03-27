using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DongPhuong.Domain.Entities.Features.PreparedGoods;

public class PreparedGoodEntityConfiguration : IEntityTypeConfiguration<PreparedGood>
{
    public void Configure(EntityTypeBuilder<PreparedGood> builder)
    {
        const int maxBaseString = (int)Max.BaseString;
        const int precisionPrice = (int)Precision.Price;
        const int scalePrice = (int)Scale.Price;

        builder.ToTable(nameof(PreparedGood).ToPlural(), Schemas.Domain);

        builder.Property(x => x.Name)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Description)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Price)
            .HasPrecision(precisionPrice, scalePrice);
    }
}