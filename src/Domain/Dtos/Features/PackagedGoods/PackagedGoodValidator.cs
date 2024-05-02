using DongPhuong.Domain.Enums;
using FluentValidation;

namespace DongPhuong.Domain.Dtos.Features.PackagedGoods;

public class PackagedGoodDtoValidator : AbstractValidator<PackagedGoodDto>
{
    public PackagedGoodDtoValidator()
    {
        RuleFor(x => x.Name)
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Category)
            .MaximumLength((int)Max.BaseString)
            .Must(x => PackagedGoodEnums.Categories.Contains(x));

        RuleFor(x => x.Description)
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Price)
            .GreaterThan(0);

        RuleFor(x => x.Weight)
            .GreaterThan(0);
    }
}