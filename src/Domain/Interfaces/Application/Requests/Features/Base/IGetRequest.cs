using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;

public interface IGetRequest<TEntity> where TEntity : class, IEntity;