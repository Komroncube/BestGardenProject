namespace BestGarden.Infrastructure.Repositories;

internal class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
