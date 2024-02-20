using AutoMapper;
using DongPhuong.Domain.Entities;
using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Interfaces.Entities;
using FluentValidation;

namespace DongPhuong.Application.Dtos;

public class DrinkDto : DrinkQueryDto, IDrinkDto;

public class DrinkQueryDto : DrinkCommandDto
{
    public int Id { get; set; }
}

public class DrinkCommandDto
{
    public string? Name { get; set; }
    public string? Size { get; set; }
    public decimal Price { get; set; }
}

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

public class DrinkDtoMapping : Profile
{
    public DrinkDtoMapping()
    {
        CreateMap<DrinkDto, Drink>()
            .ReverseMap();

        CreateMap<DrinkCommandDto, Drink>()
            .IncludeBase<DrinkDto, Drink>()
            .ReverseMap();

        CreateMap<DrinkQueryDto, Drink>()
            .IncludeBase<DrinkDto, Drink>()
            .ReverseMap();
    }
}