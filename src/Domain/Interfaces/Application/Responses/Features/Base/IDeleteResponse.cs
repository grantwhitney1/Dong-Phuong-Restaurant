using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

public interface IDeleteResponse<TEntity> where TEntity : class, IEntity;