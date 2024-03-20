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

        builder.HasData(
            new PreparedGood("chả giò", "4 fried shrimp and pork egg rolls", 5.00m),
            new PreparedGood("gỏi cuốn", "2 shrimp & pork spring rolls", 5.00m),
            new PreparedGood("bún gà nướng", "grilled chicken vermicelli", 11.00m),
            new PreparedGood("bún thịt nướng", "grilled pork vermicelli", 11.00m),
            new PreparedGood("bún nướng", "grilled beef vermicelli", 11.00m),
            new PreparedGood("bún tôm nướng", "grilled shrimp vermicelli", 12.50m),
            new PreparedGood("bún chả giò", "egg roll vermicelli", 11.00m),
            new PreparedGood("bún bò xao", "lemongrass beef vermicelli", 12.50m),
            new PreparedGood("bún nem nướng", "Vietnamese sausage vermicelli", 11.00m),
            new PreparedGood("bún đậu hủ nướng", "grilled tofu vermicelli", 9.00m),
            new PreparedGood("cơm suon nướng", "grilled pork chop rice bowl", 11.00m),
            new PreparedGood("cơm gà nướng", "grilled chicken rice bowl", 11.00m),
            new PreparedGood("cơm thịt nướng", "grilled pork rice bowl", 11.00m),
            new PreparedGood("cơm bò nướng", "grilled beef rice bowl", 11.00m),
            new PreparedGood("cơm tôm nướng", "grilled shrimp rice bowl", 13.00m),
            new PreparedGood("cơm sườn đại hàn", "Korean short ribs rice bowl", 13.00m),
            new PreparedGood("cơm đậu hủ nướng", "grilled tofu rice bowl", 11.00m),
            new PreparedGood("cơm bì suon", "pork chop & shredded pork skin rice bowl", 12.00m),
            new PreparedGood("cơm bì gà", "chicken & shredded pork skin rice bowl", 12.00m),
            new PreparedGood("cơm bì thịt nướng", "pork & shredded pork skin rice bowl", 12.00m),
            new PreparedGood("cơm bì bò nướng", "beef & shredded pork skin rice bowl", 12.00m),
            new PreparedGood("cơm bì tôm", "shrimp & shredded pork skin rice bowl", 15.00m),
            new PreparedGood("cơm bì sườn đại hàn", "K-short ribs & shredded pork skin rice bowl", 15.00m),
            new PreparedGood("cơm bò luc lac", "shaky beef rice bowl", 14.00m),
            new PreparedGood("bánh hỏi gà nướng", "grilled chicken vermicelli roll", 14.00m),
            new PreparedGood("bánh hỏi thịt nướng", "grilled pork vermicelli roll", 14.00m),
            new PreparedGood("bánh hỏi bò nướng", "grilled beef vermicelli roll", 14.00m),
            new PreparedGood("bánh hỏi tôm nướng", "grilled shrimp vermicelli roll", 15.00m),
            new PreparedGood("bánh hỏi sườn đại hàn", "Korean short ribs vermicelli roll", 15.00m),
            new PreparedGood("bánh hỏi nem nướng", "Viet sausage vermicelli roll", 12.50m),
            new PreparedGood("bánh hỏi đậu hủ nướng", "grilled tofu vermicelli roll", 12.50m),
            new PreparedGood("salad gà nướng", "grilled chicken salad", 10.00m),
            new PreparedGood("salad thịt nướng", "grilled pork salad", 10.00m),
            new PreparedGood("salad bò nướng", "grilled beef salad", 11.00m),
            new PreparedGood("salad tôm nướng", "grilled shrimp salad", 12.00m),
            new PreparedGood("salad chả giò", "egg roll (bún) salad", 10.00m),
            new PreparedGood("salad nem nướng", "Vietnamese sausage salad", 11.00m),
            new PreparedGood("salad đậu hủ nướng", "grilled tofu salad", 10.00m),
            new PreparedGood("phở đặc biệt", "combination phở", 12.00m),
            new PreparedGood("phở chin", "brisket phở", 11.00m),
            new PreparedGood("phở tái", "eye of round phở", 11.00m),
            new PreparedGood("phở bò viên", "meatball phở", 11.00m),
            new PreparedGood("phở tôm", "shrimp phở", 13.00m),
            new PreparedGood("phở rau", "steamed veggies phở", 10.00m),
            new PreparedGood("phở nước lèo", "broth & noodles phở", 9.00m),
            new PreparedGood("kid’s phở", "choose any two options", 5.00m),
            new PreparedGood("bún bò huế", "spicy vermicelli with pork hock & beef", 12.00m),
            new PreparedGood("bún riêu", "house special soup with vermicelli, shrimp & fish cake", 12.00m),
            new PreparedGood("hủ tiếu satế", "big flat rice noodle with spicy beef soup", 12.00m),
            new PreparedGood("hủ tiếu dai hoặc mì", "transparent, rice, or egg noodles w pork/seafood in pork broth", 12.00m),
            new PreparedGood("hủ tiếu dai hoặc mì tôm", "transparent, rice, or egg noodles w shrimp", 13.00m),
            new PreparedGood("hoành thánh mì hoặc súp", "egg noodles or soup only w wonton, pork/seafood in pork broth", 13.00m),
            new PreparedGood("hủ tiếu khô hoặc mì", "dry stir fried transparent, rice, or egg noodles w pork/seafood (add wontons for $1)", 13.00m),
            new PreparedGood("hoành thánh mì khô", "dry stir fried egg noodles w wonton, pork/seafood", 14.00m)
        );
    }
}