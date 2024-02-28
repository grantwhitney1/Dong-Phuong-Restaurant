using AutoMapper;
using DongPhuong.Domain.Entities.Features.Drinks;

namespace DongPhuong.Application.Dtos.Features.Drinks;

public class DrinkDtoMapping : Profile
{
    public DrinkDtoMapping()
    {
        CreateMap<DrinkDto, Drink>()
            .ReverseMap();

        CreateMap<DrinkDto, Drink>()
            .IncludeBase<DrinkDto, Drink>()
            .ReverseMap();

        CreateMap<DrinkGetDto, Drink>()
            .IncludeBase<DrinkDto, Drink>()
            .ReverseMap();
    }
}