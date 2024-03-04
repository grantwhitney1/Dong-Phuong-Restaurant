using AutoMapper;
using DongPhuong.Domain.Entities.Features.PackagedGoods;

namespace DongPhuong.Domain.Dtos.Features.PackagedGoods;

public class PackagedGoodDtoMapping : Profile
{
    public PackagedGoodDtoMapping()
    {
        CreateMap<PackagedGoodDto, PackagedGood>()
            .ReverseMap();
        CreateMap<PackagedGoodGetDto, PackagedGood>()
            .ReverseMap();
    }
}