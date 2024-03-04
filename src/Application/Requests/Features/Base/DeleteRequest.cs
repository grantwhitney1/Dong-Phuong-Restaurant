using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Application.Requests.Features.Base;

public class DeleteRequest<TEntity> : IDeleteRequest<TEntity> where TEntity : class, IEntity;