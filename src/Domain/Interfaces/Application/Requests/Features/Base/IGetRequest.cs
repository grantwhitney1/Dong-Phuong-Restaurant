using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

public interface IGetRequest<TDto> where TDto : class, IDto
{
    public int Limit { get; set; }
    public int Page { get; set; }
}