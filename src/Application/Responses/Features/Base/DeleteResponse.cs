using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;

namespace DongPhuong.Application.Responses.Features.Base;

public class DeleteResponse<TDto> : Response, IDeleteResponse<TDto> where TDto : class, IDto;