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
            new Drink(DrinkNames.Avocado, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Avocado, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Avocado, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Banana, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Banana, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Banana, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Cappucino, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Cappucino, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Cappucino, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Coconut, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Coconut, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Coconut, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Coffee, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Coffee, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Coffee, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.GreenApple, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.GreenApple, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.GreenApple, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Honeydew, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Honeydew, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Honeydew, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Jackfruit, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Jackfruit, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Jackfruit, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Lychee, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Lychee, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Lychee, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Mango, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Mango, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Mango, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.MatchaGreenTea, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.MatchaGreenTea, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.MatchaGreenTea, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.MilkTea, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.MilkTea, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.MilkTea, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Papaya, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Papaya, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Papaya, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.PassionFruit, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.PassionFruit, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.PassionFruit, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Peach, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Peach, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Peach, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Strawberry, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Strawberry, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Strawberry, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Taro, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Taro, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Taro, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.ThaiTea, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.ThaiTea, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.ThaiTea, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Watermelon, DrinkSizes.Medium, 5.00m),
            new Drink(DrinkNames.Watermelon, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Watermelon, DrinkSizes.Large, 7.00m),

            new Drink(DrinkNames.Cola, DrinkSizes.Medium, 3.00m),
            new Drink(DrinkNames.Cola, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Cola, DrinkSizes.Large, 4.00m),

            new Drink(DrinkNames.Lemonade, DrinkSizes.Medium, 3.00m),
            new Drink(DrinkNames.Lemonade, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Lemonade, DrinkSizes.Large, 4.00m),

            new Drink(DrinkNames.RootBeer, DrinkSizes.Medium, 3.00m),
            new Drink(DrinkNames.RootBeer, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.RootBeer, DrinkSizes.Large, 4.00m),

            new Drink(DrinkNames.Coke, DrinkSizes.Medium, 3.00m),
            new Drink(DrinkNames.Coke, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Coke, DrinkSizes.Large, 4.00m),

            new Drink(DrinkNames.Sprite, DrinkSizes.Medium, 3.00m),
            new Drink(DrinkNames.Sprite, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Sprite, DrinkSizes.Large, 4.00m),

            new Drink(DrinkNames.DrPepper, DrinkSizes.Medium, 3.00m),
            new Drink(DrinkNames.DrPepper, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.DrPepper, DrinkSizes.Large, 4.00m),

            new Drink(DrinkNames.Tea, DrinkSizes.Medium, 3.00m),
            new Drink(DrinkNames.Tea, DrinkSizes.Small, 2.00m),
            new Drink(DrinkNames.Tea, DrinkSizes.Large, 4.00m),

            new Drink(DrinkNames.Water, DrinkSizes.Medium, 0.00m),
            new Drink(DrinkNames.Water, DrinkSizes.Small, 0.00m),
            new Drink(DrinkNames.Water, DrinkSizes.Large, 0.00m)
        );
    }
}