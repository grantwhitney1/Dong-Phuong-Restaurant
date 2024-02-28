using DongPhuong.Domain.Enums;
using FluentValidation;

namespace DongPhuong.Application.Dtos.Features.PreparedGoods;

public class PreparedGoodDtoValidator : AbstractValidator<PreparedGoodDto>
{
    public PreparedGoodDtoValidator()
    {
        RuleFor(x => x.Name)
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Description)
            .MaximumLength((int)Max.BaseString);

        RuleFor(x => x.Price)
            .GreaterThan(0);
    }
}