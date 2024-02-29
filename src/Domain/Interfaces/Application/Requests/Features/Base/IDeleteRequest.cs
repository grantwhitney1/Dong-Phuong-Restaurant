using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

public interface IDeleteRequest<TEntity> where TEntity : class, IEntity;