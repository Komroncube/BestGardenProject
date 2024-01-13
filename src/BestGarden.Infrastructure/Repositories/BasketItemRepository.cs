namespace BestGarden.Infrastructure.Repositories;
internal class BasketItemRepository : GenericRepository<BasketItem>, IBasketItemRepository
{
    public BasketItemRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
