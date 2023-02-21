using Cluster.Domain.Interfaces;
using Cluster.Domain.Models;
using Cluster.Domain.Models.Validations;
using Cluster.Infra.Data.Interfaces;

namespace Cluster.Service.Services;

public class CartService : BaseService
{
    private readonly ICartRepository _cartRepository;

    public CartService(ICartRepository cartRepository, INotifier notifier) : base(notifier)
    {
        _cartRepository = cartRepository;
    }

    public async Task Add(Cart cart)
    {
        if (!ExecuteValidation(new CartValidation(), cart)) return;

        await _cartRepository.Add(cart);
    }

    public async Task Remove(int id)
    {
        await _cartRepository.Remove(id.ToString());
    }

    public async Task Update(Cart cart)
    {
        if (!ExecuteValidation(new CartValidation(), cart)) return;

        await _cartRepository.Update(cart);
    }

    public void Dispose()
    {
        _cartRepository?.Dispose();
    }
}
