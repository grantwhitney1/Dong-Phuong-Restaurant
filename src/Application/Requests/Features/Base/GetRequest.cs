using DongPhuong.Domain.Interfaces.Application.Requests.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Application.Requests.Features.Base;

public class GetRequest<TEntity> : IGetRequest<TEntity> where TEntity : class, IEntity
{
    public int Limit { get; set; }
    public int Page { get; set; }
}