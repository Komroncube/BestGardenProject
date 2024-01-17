using BestGarden.Domain.Enums;

namespace BestGarden.Application.UseCases.Orders.Queries.GetOrderStatus;
public class GetOrderStatusQuery : IQuery<OrderStatus>
{
    public int OrderId { get; set; }
}
