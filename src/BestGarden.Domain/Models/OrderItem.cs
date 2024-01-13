namespace BestGarden.Domain.Models;
public class OrderItem : BaseDomainEntity
{
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
}
