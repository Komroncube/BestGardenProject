namespace BestGarden.Domain.Models;
public class Product : BaseDomainEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImagePath { get; set; }
    public int CatalogId { get; set; }
    public virtual Catalog Catalog { get; set; }

    public virtual ICollection<BasketItem> BasketItems { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
}
