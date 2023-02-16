using System.Linq.Expressions;
using Cluster.Domain.Models;

namespace Cluster.Infra.Data.Interfaces;

public interface IBaseRepository<TEntity> : IDisposable where TEntity : Entity
{
    Task Add(TEntity entity);
    Task<TEntity> GetById(string id);
    Task<List<TEntity>> GetAll();
    Task Update(TEntity entity);
    Task Remove(string id);
    Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
    Task<int> SaveChanges();
}