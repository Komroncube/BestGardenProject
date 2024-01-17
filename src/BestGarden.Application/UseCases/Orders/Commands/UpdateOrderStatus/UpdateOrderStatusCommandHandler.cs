using BestGarden.Application.UseCases.Users.Notifications.OrderCreated;
using BestGarden.Domain.Enums;

namespace BestGarden.Application.UseCases.Orders.Commands.UpdateOrderStatus;
public class UpdateOrderStatusCommandHandler : ICommandHandler<UpdateOrderStatusCommand, Order>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMediator _mediator;

    public UpdateOrderStatusCommandHandler(IOrderRepository orderRepository, IMediator mediator)
    {
        _orderRepository = orderRepository;
        _mediator = mediator;
    }

    public async Task<Order> Handle(UpdateOrderStatusCommand request, CancellationToken cancellationToken)
    {
        Order order = await _orderRepository.GetAsync(request.OrderId, cancellationToken);
        order.OrderStatus = request.OrderStatus;
        if (order.OrderStatus == OrderStatus.Completed)
        {
            await _mediator.Publish(new OrderDeliveredNotification(order.UserId), cancellationToken);
        }
        return await _orderRepository.UpdateAsync(order, cancellationToken);
    }
}
