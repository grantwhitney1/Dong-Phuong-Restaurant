using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;

public interface IGetResponse<TEntity> : IResponse where TEntity : class, IEntity;