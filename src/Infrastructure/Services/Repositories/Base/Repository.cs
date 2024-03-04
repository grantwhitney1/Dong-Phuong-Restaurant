using AutoMapper;
using DongPhuong.Domain.Interfaces.Domain.Dtos.Base;
using DongPhuong.Domain.Interfaces.Domain.Entities.Base;
using DongPhuong.Domain.Interfaces.Infrastructure.Services.Repositories.Base;
using DongPhuong.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DongPhuong.Infrastructure.Services.Repositories.Base;

public class Repository<TEntity>(DataContext dataContext, ILogger<Repository<TEntity>> logger, IMapper mapper) :
    IRepository<TEntity> where TEntity : class, IEntity
{
    private readonly DbSet<TEntity> _entities = dataContext.Set<TEntity>();

    public virtual async Task BeforeSaveAsync()
    {
        await Task.CompletedTask;
    }

    public virtual async Task SaveAsync()
    {
        try
        {
            await BeforeSaveAsync();
            await dataContext.SaveChangesAsync();
            await AfterSaveAsync();
        }
        catch (Exception exception)
        {
            logger.LogError(exception, "Source: {source}, Message: {message}", exception.Source, exception.Message);
            throw;
        }
    }

    public virtual async Task AfterSaveAsync()
    {
        await Task.CompletedTask;
    }

    public void Create(IDto dto)
    {
        _entities.Add(mapper.Map<TEntity>(dto));
    }

    public async Task<TEntity?> GetAsync(int id)
    {
        return await _entities.FirstOrDefaultAsync(x => x.Id == id);
    }

    public IQueryable<TEntity> GetAll()
    {
        return _entities.AsQueryable();
    }

    public async Task<TEntity?> DeleteAsync(int id)
    {
        var entity = await GetAsync(id);
        if (entity is not null)
            _entities.Remove(entity);
        return entity;
    }
}