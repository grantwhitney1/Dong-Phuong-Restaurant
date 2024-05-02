using DongPhuong.Domain.Enums;
using FluentValidation;

namespace DongPhuong.Domain.Dtos.Features.Drinks;

public class DrinkDtoValidator : AbstractValidator<DrinkDto>
{
    public DrinkDtoValidator()
    {
        RuleFor(x => x.Name)
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Category)
            .MaximumLength((int)Max.BaseString)
            .Must(x => DrinkCategories.Categories.Contains(x));

        RuleFor(x => x.Size)
            .NotEmpty()
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Price)
            .GreaterThan(0);
    }
}