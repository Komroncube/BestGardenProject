﻿using Microsoft.AspNetCore.Http;

namespace BestGarden.Application.DTOs.Products;
public class ProductCreateDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public IFormFile Image { get; set; }
    public int CatalogId { get; set; }
}
