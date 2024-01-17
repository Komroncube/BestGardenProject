using Microsoft.EntityFrameworkCore;

namespace BestGarden.Infrastructure.Repositories;
internal class BasketItemRepository : GenericRepository<BasketItem>, IBasketItemRepository
{
    private readonly ApplicationDbContext _dbContext;
    public BasketItemRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    /// <summary>
    /// basketdagi productni olish
    /// </summary>
    /// <param name="userId">
    /// foydalanuvchi idsi (jwt tokendan olinadi)</param>
    /// <param name="productId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>basketdagi product</returns>
    public async Task<BasketItem> GetBasketItemByUserIdAsync(int userId, int productId, CancellationToken cancellationToken)
    {
        return await _dbContext.BasketItems.FirstOrDefaultAsync(x => x.UserId == userId && x.ProductId == productId, cancellationToken);
    }
}
