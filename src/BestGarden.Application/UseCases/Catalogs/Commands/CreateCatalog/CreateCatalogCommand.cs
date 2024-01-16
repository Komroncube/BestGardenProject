using BestGarden.Application.DTOs.Catalogs;

namespace BestGarden.Application.UseCases.Catalogs.Commands.CreateCatalog;

public class CreateCatalogCommand : ICommand<Catalog>
{
    public CatalogCreateDTO CatalogCreateDto { get; set; }
}
