using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Application.Requests.Features.Base;

public class PutRequest<TDto> : IPutRequest<TDto> where TDto : class?, IDto?
{
    public TDto? Dto { get; set; }
}