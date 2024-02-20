using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Interfaces.Entities;
using FluentValidation;

namespace DongPhuong.Application.Dtos;

public class PackagedGoodDto : PackagedGoodQueryDto, IPackagedGoodDto;

public class PackagedGoodQueryDto : PackagedGoodCommandDto
{
    public int Id { get; set; }
}

public class PackagedGoodCommandDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Weight { get; set; }
    public decimal Price { get; set; }
}

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