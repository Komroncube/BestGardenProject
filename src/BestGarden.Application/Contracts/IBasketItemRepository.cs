namespace BestGarden.Application.Contracts;
public interface IBasketItemRepository : IGenericRepository<BasketItem>
{
    Task<BasketItem> GetBasketItemByUserIdAsync(int userId, int productId, CancellationToken cancellationToken);
}
