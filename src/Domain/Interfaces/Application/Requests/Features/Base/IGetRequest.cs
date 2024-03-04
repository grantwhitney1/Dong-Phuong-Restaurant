using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

public interface IGetRequest<TDto> where TDto : class, IDto
{
    public int Limit { get; set; }
    public int Page { get; set; }
}