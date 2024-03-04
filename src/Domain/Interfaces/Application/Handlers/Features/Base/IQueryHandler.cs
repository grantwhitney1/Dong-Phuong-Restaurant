using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Domain.Interfaces.Application.Handlers.Features.Base;

public interface IQueryHandler
{
    public Task<IGetResponse<TDto>> HandleAsync<TDto>(IGetRequest<TDto> request) where TDto : class, IDto;
    public Task<IGetResponse<TDto>> HandleAsync<TDto>(int id) where TDto : class, IDto;
    public Task<IGetResponse<TDto>> HandleAsync<TDto>() where TDto : class, IDto;
}