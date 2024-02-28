using DongPhuong.Domain.Enums;
using FluentValidation;

namespace DongPhuong.Application.Dtos.Features.PackagedGoods;

public class PackagedGoodDtoValidator : AbstractValidator<PackagedGoodDto>
{
    public PackagedGoodDtoValidator()
    {
        RuleFor(x => x.Name)
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Description)
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Price)
            .GreaterThan(0);

        RuleFor(x => x.Weight)
            .GreaterThan(0);
    }
}