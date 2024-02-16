using DongPhuong.Application.Dtos;
using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Extensions;
using DongPhuong.Domain.Interfaces.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DongPhuong.Domain.Entities;

public class PackagedGood : PackagedGoodDto, IEntity;

public class PackagedGoodEntityConfiguration : IEntityTypeConfiguration<PackagedGood>
{
    public void Configure(EntityTypeBuilder<PackagedGood> builder)
    {
        // lengths
        const int maxBaseString = (int)Max.BaseString;
        const int maxPrice = (int)Max.Price;
        const int maxWeight = (int)Max.Weight;
        // precision
        const int precisionPrice = (int)Precision.Price;
        const int precisionWeight = (int)Precision.Weight;
        
        builder.ToTable(nameof(PackagedGood).ToPlural(), Schemas.Domain);

        builder.Property(x => x.Name)
            .HasMaxLength(maxBaseString);
        
        builder.Property(x => x.Description)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Price)
            .HasPrecision(precisionPrice, maxPrice);
        
        builder.Property(x => x.Weight)
            .HasPrecision(precisionWeight, maxWeight);
    }
}