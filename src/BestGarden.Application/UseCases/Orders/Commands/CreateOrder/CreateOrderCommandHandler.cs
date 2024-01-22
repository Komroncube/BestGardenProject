using BestGarden.Application.UseCases.Baskets.Queries.GetBasketDetail;
namespace BestGarden.Application.UseCases.Orders.Commands.CreateOrder;
public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand, Order>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IUserRepository _userRepository;
    private readonly IMediator _mediator;

    public CreateOrderCommandHandler(IOrderRepository orderRepository, IMediator mediator, IUserRepository userRepository)
    {
        _orderRepository = orderRepository;
        _mediator = mediator;
        _userRepository = userRepository;
    }

    public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        Order order = new()
        {
            UserId = 2,
            Address = request.Address,
            DeliveryType = request.DeliveryType,
        };
        try
        {
            User user = await _userRepository.GetAsync(2, cancellationToken);
            if (!user.BasketItems.Any())
                throw new Exception("User has an active order");

            var getBasketItemsQuery = new GetBasketDetailQuery();
            var basketItems = await _mediator.Send(getBasketItemsQuery, cancellationToken);

            order.OrderItems = basketItems.Select(basketItem => new OrderItem()
            {
                ProductId = basketItem.Product.Id,
                Quantity = basketItem.Quantity,
                Price = basketItem.Product.Price * (100 - (decimal)user.LoyaltyDiscountStatus) / 100,
            }).ToList();

            user.BasketItems.Clear();

            return await _orderRepository.AddAsync(order, cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
