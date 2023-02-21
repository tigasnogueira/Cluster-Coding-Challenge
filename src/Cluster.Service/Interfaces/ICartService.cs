using Cluster.Domain.Models;

namespace Cluster.Service.Interfaces;

public interface ICartService
{
    Task Add(Cart cart);
    Task Update(Cart cart);
    Task Remove(int id);
}
