using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Application.Responses.Features.Base;

public class DeleteResponse<TEntity> : IDeleteResponse<TEntity> where TEntity : class, IEntity;