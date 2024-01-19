using Microsoft.AspNetCore.Http;

namespace BestGarden.Application.DTOs.Catalogs;

public class CatalogCreateDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string PlantSystem { get; set; }
    public IFormFile Image { get; set; }
}