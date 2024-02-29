using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Application.Responses.Features.Base;

public class PostResponse<TEntity> : IPostResponse<TEntity> where TEntity : class, IEntity;