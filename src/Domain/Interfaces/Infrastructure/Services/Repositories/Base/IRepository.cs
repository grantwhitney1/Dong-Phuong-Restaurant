using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;

namespace DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;

public interface IRepository<TEntity> where TEntity : class, IEntity
{
    public Task BeforeSaveAsync();
    public Task SaveAsync();
    public Task AfterSaveAsync();

    public void Create<TDto>(TDto dto) where TDto : class, IDto;
    
    public Task<TEntity?> GetAsync(int id);
    public IQueryable<TEntity> GetAll();

    public Task<TEntity?> DeleteAsync(int id);
}