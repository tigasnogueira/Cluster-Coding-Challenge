using System.Linq.Expressions;
using Cluster.Domain.Models;
using Cluster.Infra.Data.Context;
using Cluster.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cluster.Infra.Data.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity, new()
{
    protected readonly ClusterDbContext Db;
    protected readonly DbSet<TEntity> DbSet;

    protected BaseRepository(ClusterDbContext db)
    {
        Db = db;
        DbSet = db.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
    {
        return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
    }

    public virtual async Task<TEntity> GetById(string id)
    {
        return await DbSet.FindAsync(id);
    }

    public virtual async Task<List<TEntity>> GetAll()
    {
        return await DbSet.ToListAsync();
    }

    public virtual async Task Add(TEntity entity)
    {
        DbSet.Add(entity);
        await SaveChanges();
    }

    public virtual async Task Update(TEntity entity)
    {
        DbSet.Update(entity);
        await SaveChanges();
    }

    public virtual async Task Remove(string id)
    {
        DbSet.Remove(new TEntity { Id = id });
        await SaveChanges();
    }

    public async Task<int> SaveChanges()
    {
        return await Db.SaveChangesAsync();
    }

    public void Dispose()
    {
        Db?.Dispose();
    }
}
