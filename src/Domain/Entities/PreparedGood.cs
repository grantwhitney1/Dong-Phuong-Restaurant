using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Extensions;
using DongPhuong.Domain.Interfaces.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DongPhuong.Domain.Entities;

public class PreparedGood : IPreparedGood
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}

public class PreparedGoodEntityConfiguration : IEntityTypeConfiguration<PreparedGood>
{
    public void Configure(EntityTypeBuilder<PreparedGood> builder)
    {
        // lengths
        const int maxBaseString = (int)Max.BaseString;
        // precision
        const int precisionPrice = (int)Precision.Price;
        // scale
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