using Cluster.Domain.Models;

namespace Cluster.Infra.Data.Interfaces;

public interface IMenuItemRepository : IBaseRepository<MenuItem>
{
    Task<MenuItem> GetItemByName(string name);
}