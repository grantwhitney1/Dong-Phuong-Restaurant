using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

public interface IDeleteResponse<TDto> : IResponse where TDto : class, IDto;