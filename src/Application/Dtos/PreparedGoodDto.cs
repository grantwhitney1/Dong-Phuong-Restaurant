using AutoMapper;
using DongPhuong.Domain.Entities;
using DongPhuong.Domain.Enums;
using DongPhuong.Domain.Interfaces.Entities;
using FluentValidation;

namespace DongPhuong.Application.Dtos;

public class PreparedGoodDto : PreparedGoodQueryDto, IPreparedGoodDto;

public class PreparedGoodQueryDto : PreparedGoodCommandDto
{
    public int Id { get; set; }
}

public class PreparedGoodCommandDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}

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

public class PreparedGoodDtoMapping : Profile
{
    public PreparedGoodDtoMapping()
    {
        CreateMap<PreparedGoodDto, PreparedGood>()
            .ReverseMap();
        
        CreateMap<PreparedGoodCommandDto, PreparedGood>()
            .IncludeBase<PreparedGoodDto, PreparedGood>()
            .ReverseMap();
        
        CreateMap<PreparedGoodQueryDto, PreparedGood>()
            .IncludeBase<PreparedGoodDto, PreparedGood>()
            .ReverseMap();
    }
}