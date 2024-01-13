namespace BestGarden.Domain.Models;

public class BasketItem : BaseDomainEntity
{
    public int UserId { get; set; }
    public User User { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
