namespace BestGarden.Infrastructure.Repositories;

internal class CatalogRepository : GenericRepository<Catalog>, ICatalogRepository
{
    public CatalogRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
