using DongPhuong.Application.Dtos;
using DongPhuong.Presentation.Dtos.Responses.Base;

namespace DongPhuong.Presentation.Dtos.Responses;

public class PackagedGoodResponse : BaseResponse
{
    public PackagedGoodQueryDto? PackagedGoodQueryDto { get; set; }
}