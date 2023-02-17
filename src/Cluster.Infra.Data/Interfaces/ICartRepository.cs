using Cluster.Domain.Models;

namespace Cluster.Infra.Data.Interfaces;

public interface ICartRepository : IBaseRepository<Cart>
{
    Task<Cart> GetCartByStatus(string status);
}
