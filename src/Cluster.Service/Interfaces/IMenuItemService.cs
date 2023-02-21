using Cluster.Domain.Models;

namespace Cluster.Service.Interfaces;

public interface IMenuItemService
{
    Task Add(MenuItem item);
    Task Update(MenuItem item);
    Task Remove(int id);
}
