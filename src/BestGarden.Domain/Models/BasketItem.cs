namespace BestGarden.Domain.Models;

public class BasketItem : BaseDomainEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

    public int Quantity { get; set; } = 1;
}
