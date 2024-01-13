using BestGarden.Domain;
using Microsoft.EntityFrameworkCore;

namespace BestGarden.Infrastructure.Repositories;

internal abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseDomainEntity
{
    private readonly ApplicationDbContext _dbContext;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;

    }
    public async Task<T> GetAsync(int id, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<T>().FindAsync(id, cancellationToken);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Set<T>().ToListAsync(cancellationToken);
    }

    public async Task<bool> ExistsAsync(int id, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<T>().AnyAsync(e => e.Id == id, cancellationToken: cancellationToken);
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
    {
        _dbContext.Set<T>().Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return entity;

    }

    public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Set<T>().FindAsync(id, cancellationToken);
        if (entity == null)
        {
            return false;
        }
        _dbContext.Set<T>().Remove(entity);
        return await _dbContext.SaveChangesAsync(cancellationToken) > 0;
    }
}
