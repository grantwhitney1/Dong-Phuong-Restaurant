using DongPhuong.Domain.Interfaces.Data;

namespace DongPhuong.Domain.Interfaces.Repositories;

public interface IRepository
{
    public IQueryable<TEntity> All<TEntity>() where TEntity : class, IEntity;
    public Task<TEntity> FindAsync<TEntity>(int id) where TEntity : class, IEntity;
    public Task RemoveAsync<TEntity>(int id) where TEntity : class, IEntity;
    public Task<TEntity> CreateAsync<TEntity>(TEntity entity) where TEntity : class, IEntity;
    public Task<TEntity> UpdateAsync<TEntity>(int id, TEntity entity) where TEntity : class, IEntity;
}