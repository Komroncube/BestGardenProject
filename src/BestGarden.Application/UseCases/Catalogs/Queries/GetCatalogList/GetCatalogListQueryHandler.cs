﻿using BestGarden.Application.DTOs.Catalogs;

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
            Name = catalog.Name,
            ProductQuantity = catalog.Products.Count,
            ImagePath = catalog.ImagePath,
        });
        return catalogList;
    }
}
