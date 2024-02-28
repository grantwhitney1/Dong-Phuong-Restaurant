using DongPhuong.Domain.Enums;
using FluentValidation;

namespace DongPhuong.Application.Dtos.Features.Drinks;

public class DrinkDtoValidator : AbstractValidator<DrinkDto>
{
    public DrinkDtoValidator()
    {
        RuleFor(x => x.Name)
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Size)
            .NotEmpty()
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Price)
            .GreaterThan(0);
    }
}