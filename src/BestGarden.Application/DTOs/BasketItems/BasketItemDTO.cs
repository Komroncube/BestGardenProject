using BestGarden.Application.DTOs.Products;

namespace BestGarden.Application.DTOs.BasketItems;
public class BasketItemDTO
{
    public ProductListDTO Product { get; set; }
    public int Quantity { get; set; }
}
