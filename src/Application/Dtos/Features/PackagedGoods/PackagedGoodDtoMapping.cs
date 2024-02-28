using AutoMapper;
using DongPhuong.Domain.Entities.Features.PackagedGoods;

namespace DongPhuong.Application.Dtos.Features.PackagedGoods;

public class PackagedGoodDtoMapping : Profile
{
    public PackagedGoodDtoMapping()
    {
        CreateMap<PackagedGoodDto, PackagedGood>()
            .ReverseMap();

        CreateMap<PackagedGoodDto, PackagedGood>()
            .IncludeBase<PackagedGoodDto, PackagedGood>()
            .ReverseMap();

        CreateMap<PackagedGoodGetDto, PackagedGood>()
            .IncludeBase<PackagedGoodDto, PackagedGood>()
            .ReverseMap();
    }
}