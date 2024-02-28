using AutoMapper;
using DongPhuong.Domain.Entities.Features.PreparedGoods;

namespace DongPhuong.Application.Dtos.Features.PreparedGoods;

public class PreparedGoodDtoMapping : Profile
{
    public PreparedGoodDtoMapping()
    {
        CreateMap<PreparedGoodDto, PreparedGood>()
            .ReverseMap();

        CreateMap<PreparedGoodDto, PreparedGood>()
            .IncludeBase<PreparedGoodDto, PreparedGood>()
            .ReverseMap();

        CreateMap<PreparedGoodGetDto, PreparedGood>()
            .IncludeBase<PreparedGoodDto, PreparedGood>()
            .ReverseMap();
    }
}