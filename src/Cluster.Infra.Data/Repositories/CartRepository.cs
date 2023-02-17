using Cluster.Domain.Models;
using Cluster.Infra.Data.Context;
using Cluster.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cluster.Infra.Data.Repositories;

public class CartRepository : BaseRepository<Cart>, ICartRepository
{
    public CartRepository(ClusterDbContext context) : base(context) { }

    public async Task<Cart> GetCartByStatus(string status)
    {
        return await Db.Carts.AsNoTracking()
            .Include(c => c.Status)
            .FirstOrDefaultAsync(c => c.Status == status);
    }
}
