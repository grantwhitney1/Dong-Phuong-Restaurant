using DongPhuong.Application.Dtos.Responses.Base;

namespace DongPhuong.Application.Dtos.Responses;

public class PackagedGoodResponse : BaseResponse
{
    public ICollection<PackagedGoodQueryDto> PackagedGoodQueryDto { get; set; } = new List<PackagedGoodQueryDto>();
}