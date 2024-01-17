using BestGarden.Domain.Enums;

namespace BestGarden.Application.UseCases.Orders.Commands.CreateOrder;
public class CreateOrderCommand : ICommand<Order>
{
    public string Address { get; set; }
    public DeliveryType DeliveryType { get; set; }
}
