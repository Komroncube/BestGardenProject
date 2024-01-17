using BestGarden.Domain.Enums;

namespace BestGarden.Application.UseCases.Orders.Queries.GetOrderStatus;
public class GetOrderStatusQueryHandler : IQueryHandler<GetOrderStatusQuery, OrderStatus>
{
    private readonly IOrderRepository _orderRepository;

    public GetOrderStatusQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<OrderStatus> Handle(GetOrderStatusQuery request, CancellationToken cancellationToken)
    {
        Order order = await _orderRepository.GetAsync(request.OrderId, cancellationToken);
        return order.OrderStatus;
    }
}
