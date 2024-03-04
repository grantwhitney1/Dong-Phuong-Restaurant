using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Application.Responses.Features.Base;

public class PutResponse<TDto> : Response, IPutResponse<TDto> where TDto : class?, IDto?
{
    public TDto? Dto { get; set; }
}