using AutoMapper;
using DongPhuong.Domain.Entities.Features.Drinks;

namespace DongPhuong.Domain.Dtos.Features.Drinks;

public class DrinkDtoMapping : Profile
{
    public DrinkDtoMapping()
    {
        CreateMap<DrinkGetDto, Drink>()
            .ReverseMap();
        CreateMap<DrinkDto, Drink>()
            .ReverseMap();
    }
}