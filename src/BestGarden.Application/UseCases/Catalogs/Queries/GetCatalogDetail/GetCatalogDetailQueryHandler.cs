using BestGarden.Application.DTOs.Catalogs;
using BestGarden.Application.DTOs.Products;

namespace BestGarden.Application.UseCases.Catalogs.Queries.GetCatalogDetail;
public class GetCatalogDetailQueryHandler : IQueryHandler<GetCatalogDetailQuery, CatalogDetailDTO>
{
    private readonly ICatalogRepository _catalogRepository;

    public GetCatalogDetailQueryHandler(ICatalogRepository catalogRepository)
    {
        _catalogRepository = catalogRepository;
    }

    public async Task<CatalogDetailDTO> Handle(GetCatalogDetailQuery request, CancellationToken cancellationToken)
    {
        Catalog catalog = await _catalogRepository.GetAsync(request.Id, cancellationToken);
        CatalogDetailDTO catalogDetail = new CatalogDetailDTO
        {
            Id = catalog.Id,
            Name = catalog.Name,
            Description = catalog.Description,
            PlantSystem = catalog.PlantSystem,
            Products = catalog.Products.Select(product => new ProductListDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImagePath = product.ImagePath

            })
        };
        return catalogDetail;
    }
}
