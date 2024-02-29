using DongPhuong.Domain.Interfaces.Application.Responses.Features.Base;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Application.Responses.Features.Base;

public class GetResponse<TEntity> : Response, IGetResponse<TEntity> where TEntity : class, IEntity
{
    public virtual IEnumerable<IDto> Data { get; set; } = new List<IDto>();
}