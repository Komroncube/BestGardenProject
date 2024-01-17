using BestGarden.Domain.Enums;

namespace BestGarden.Application.DTOs.Orders;
public class OrderDTO
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public decimal TotalPrice { get; set; }
}
