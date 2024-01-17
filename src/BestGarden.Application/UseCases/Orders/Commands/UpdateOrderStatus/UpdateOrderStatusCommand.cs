using BestGarden.Domain.Enums;

namespace BestGarden.Application.UseCases.Orders.Commands.UpdateOrderStatus;
public class UpdateOrderStatusCommand : ICommand<Order>
{
    public int OrderId { get; set; }
    public OrderStatus OrderStatus { get; set; }
}
