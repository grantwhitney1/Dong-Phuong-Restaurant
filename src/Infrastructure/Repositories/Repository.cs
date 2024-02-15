using DongPhuong.Domain.Exceptions;
using DongPhuong.Domain.Interfaces.Data;
using DongPhuong.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DongPhuong.Infrastructure.Repositories;

public class Repository(DbContext context) : IRepository
{
    public virtual IQueryable<TEntity> All<TEntity>() where TEntity : class, IEntity =>
        context.Set<TEntity>().AsQueryable();

    public virtual async Task<TEntity> FindAsync<TEntity>(int id) where TEntity : class, IEntity =>
        await context.Set<TEntity>()
            .FirstOrDefaultAsync(x => x.Id == id) ?? throw new EntityNotFoundException();

    public virtual async Task RemoveAsync<TEntity>(int id) where TEntity : class, IEntity
    {
        var entity = await context.Set<TEntity>()
            .FirstOrDefaultAsync(x => x.Id == id) ?? throw new EntityNotFoundException();
        context.Set<TEntity>().Remove(entity);
        await context.SaveChangesAsync();
    }

    public virtual async Task<TEntity> CreateAsync<TEntity>(TEntity entity) where TEntity : class, IEntity
    {
        context.Set<TEntity>().Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<TEntity> UpdateAsync<TEntity>(int id, TEntity entity) where TEntity : class, IEntity
    {
        var existingEntity = await context.Set<TEntity>()
            .FirstOrDefaultAsync(x => x.Id == id) ?? throw new EntityNotFoundException();
        context.Entry(existingEntity).CurrentValues.SetValues(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}