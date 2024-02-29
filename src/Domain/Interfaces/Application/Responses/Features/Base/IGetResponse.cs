using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

public interface IGetResponse<TDto> : IResponse where TDto : class, IDto
{
    public IEnumerable<object> Data { get; set; }
}