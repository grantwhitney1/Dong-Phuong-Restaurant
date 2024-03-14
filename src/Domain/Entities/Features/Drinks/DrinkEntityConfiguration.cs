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

        builder.Property(x => x.Size)
            .HasMaxLength(maxBaseString);

        builder.Property(x => x.Price)
            .HasPrecision(precisionPrice, scalePrice);
    
    
        builder.HasData(
            new Drink { Name = DrinkNames.Avocado.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Avocado.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Avocado.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Banana.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Banana.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Banana.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Cappucino.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Cappucino.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Cappucino.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Coconut.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Coconut.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Coconut.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Coffee.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Coffee.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Coffee.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.GreenApple.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.GreenApple.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.GreenApple.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Honeydew.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Honeydew.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Honeydew.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Jackfruit.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Jackfruit.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Jackfruit.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Lychee.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Lychee.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Lychee.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Mango.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Mango.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Mango.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.MatchaGreenTea.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.MatchaGreenTea.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.MatchaGreenTea.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.MilkTea.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.MilkTea.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.MilkTea.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Papaya.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Papaya.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Papaya.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.PassionFruit.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.PassionFruit.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.PassionFruit.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Peach.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Peach.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Peach.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Strawberry.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Strawberry.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Strawberry.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Taro.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Taro.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Taro.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.ThaiTea.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.ThaiTea.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.ThaiTea.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Watermelon.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 5.00m },
            new Drink { Name = DrinkNames.Watermelon.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Watermelon.ToString(), Size = DrinkSizes.Large.ToString(), Price = 7.00m },
            
            new Drink { Name = DrinkNames.Coke.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 3.00m },
            new Drink { Name = DrinkNames.Coke.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Coke.ToString(), Size = DrinkSizes.Large.ToString(), Price = 4.00m },
            
            new Drink { Name = DrinkNames.Sprite.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 3.00m },
            new Drink { Name = DrinkNames.Sprite.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Sprite.ToString(), Size = DrinkSizes.Large.ToString(), Price = 4.00m },
            
            new Drink { Name = DrinkNames.DrPepper.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 3.00m },
            new Drink { Name = DrinkNames.DrPepper.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.DrPepper.ToString(), Size = DrinkSizes.Large.ToString(), Price = 4.00m },
            
            new Drink { Name = DrinkNames.RootBeer.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 3.00m },
            new Drink { Name = DrinkNames.RootBeer.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.RootBeer.ToString(), Size = DrinkSizes.Large.ToString(), Price = 4.00m },
            
            new Drink { Name = DrinkNames.Water.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 0.00m },
            new Drink { Name = DrinkNames.Water.ToString(), Size = DrinkSizes.Small.ToString(), Price = 0.00m },
            new Drink { Name = DrinkNames.Water.ToString(), Size = DrinkSizes.Large.ToString(), Price = 0.00m },
            
            new Drink { Name = DrinkNames.Tea.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 3.00m },
            new Drink { Name = DrinkNames.Tea.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Tea.ToString(), Size = DrinkSizes.Large.ToString(), Price = 4.00m },
            
            new Drink { Name = DrinkNames.Lemonade.ToString(), Size = DrinkSizes.Medium.ToString(), Price = 3.00m },
            new Drink { Name = DrinkNames.Lemonade.ToString(), Size = DrinkSizes.Small.ToString(), Price = 2.00m },
            new Drink { Name = DrinkNames.Lemonade.ToString(), Size = DrinkSizes.Large.ToString(), Price = 4.00m }
        );
    }
}