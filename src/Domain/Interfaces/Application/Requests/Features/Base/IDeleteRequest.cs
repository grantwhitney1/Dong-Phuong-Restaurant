using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

public interface IDeleteRequest<TDto> where TDto : class, IDto;