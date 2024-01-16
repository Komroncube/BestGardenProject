using BestGarden.Domain.Enums;

namespace BestGarden.Domain.Models;
public class Order : BaseDomainEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.Now;
    public DeliveryType DeliveryType { get; set; }
    public OrderStatus OrderStatus { get; set; } = OrderStatus.Checking;
    public string Address { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; }
}
