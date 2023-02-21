using Cluster.Domain.Models;
using Cluster.Infra.Data.Context;
using Cluster.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cluster.Infra.Data.Repositories;

public class MenuItemRepository : BaseRepository<MenuItem> , IMenuItemRepository
{
    public MenuItemRepository(ClusterDbContext context) : base(context) { }

    public async Task<MenuItem> GetItemByName(string name)
    {
        return await Db.MenuItems.AsNoTracking()
            .Include(c => c.Name)
            .FirstOrDefaultAsync(c => c.Name == name);
    }
}
