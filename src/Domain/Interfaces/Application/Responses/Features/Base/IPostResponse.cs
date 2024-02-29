using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

public interface IPostResponse<TDto> : IResponse where TDto : class, IDto
{
    public TDto? Dto { get; set; }
}