using BestGarden.Application.DTOs.Orders;

namespace BestGarden.Application.UseCases.Orders.Queries.GetOrderList;
public class GetOrderListQueryHandler : IQueryHandler<GetOrderListQuery, IEnumerable<OrderDTO>>
{
    private readonly IOrderRepository _orderRepository;

    public GetOrderListQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<IEnumerable<OrderDTO>> Handle(GetOrderListQuery request, CancellationToken cancellationToken)
    {
        var orders = await _orderRepository.GetAllAsync(cancellationToken);
        var orderList = orders.Select(order => new OrderDTO()
        {
            Id = order.Id,
            OrderDate = order.OrderDate,
            OrderStatus = order.OrderStatus,
            TotalPrice = order.OrderItems.Sum(orderItem => orderItem.Price * orderItem.Quantity),

        });

        return orderList;
    }
}
