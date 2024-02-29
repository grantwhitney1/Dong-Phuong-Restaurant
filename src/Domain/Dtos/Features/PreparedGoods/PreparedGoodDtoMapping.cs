using AutoMapper;
using DongPhuong.Domain.Entities.Features.PreparedGoods;

namespace DongPhuong.Domain.Dtos.Features.PreparedGoods;

public class PreparedGoodDtoMapping : Profile
{
    public PreparedGoodDtoMapping()
    {
        CreateMap<PreparedGoodDto, PreparedGood>()
            .ReverseMap();
        CreateMap<PreparedGoodGetDto, PreparedGood>()
            .ReverseMap();
    }
}