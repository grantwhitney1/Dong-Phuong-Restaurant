using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

public interface IPutRequest<TDto> where TDto : class?, IDto?
{
    public TDto? Dto { get; set; }
}