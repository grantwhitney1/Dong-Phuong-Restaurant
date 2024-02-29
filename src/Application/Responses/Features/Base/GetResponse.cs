using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Application.Responses.Features.Base;

public class GetResponse<TDto> : Response, IGetResponse<TDto> where TDto : class, IDto
{
    public virtual IEnumerable<object> Data { get; set; } = new List<object>();
}