using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestGarden.Application.DTOs.Catalogs;

namespace BestGarden.Application.UseCases.Catalogs.Queries.GetCatalogList;
public class GetCatalogListQueryHandler : IQueryHandler<GetCatalogListQuery, IEnumerable<CatalogListDTO>>
{
    private readonly ICatalogRepository _catalogRepository;

    public GetCatalogListQueryHandler(ICatalogRepository catalogRepository)
    {
        _catalogRepository = catalogRepository;
    }

    public async Task<IEnumerable<CatalogListDTO>> Handle(GetCatalogListQuery request, CancellationToken cancellationToken)
    {
        var catalogs = await _catalogRepository.GetAllAsync(cancellationToken);
        var catalogList = catalogs.Select(catalog => new CatalogListDTO
        {
            Id = catalog.Id,
            ProductQuantity = catalog.Products.Count
        });
        return catalogList;
    }
}
