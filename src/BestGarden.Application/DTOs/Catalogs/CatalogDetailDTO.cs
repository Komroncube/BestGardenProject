using BestGarden.Application.DTOs.Products;

namespace BestGarden.Application.DTOs.Catalogs;

public class CatalogDetailDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PlantSystem { get; set; }
    public string ImagePath { get; set; }
    public IEnumerable<ProductListDTO> Products { get; set; }
}