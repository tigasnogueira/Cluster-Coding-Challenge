using Cluster.Domain.Interfaces;
using Cluster.Domain.Models;
using Cluster.Domain.Models.Validations;
using Cluster.Infra.Data.Interfaces;

namespace Cluster.Service.Services;

public class MenuItemService : BaseService
{
    private readonly IMenuItemRepository _menuItemRepository;

    public MenuItemService(IMenuItemRepository menuItemRepository, INotifier notifier) : base(notifier)
    {
        _menuItemRepository = menuItemRepository;
    }

    public async Task Add(MenuItem menuItem)
    {
        if (!ExecuteValidation(new MenuItemValidation(), menuItem)) return;

        await _menuItemRepository.Add(menuItem);
    }

    public async Task Remove(int id)
    {
        await _menuItemRepository.Remove(id.ToString());
    }

    public async Task Update(MenuItem menuItem)
    {
        if (!ExecuteValidation(new MenuItemValidation(), menuItem)) return;

        await _menuItemRepository.Update(menuItem);
    }

    public void Dispose()
    {
        _menuItemRepository?.Dispose();
    }
}
