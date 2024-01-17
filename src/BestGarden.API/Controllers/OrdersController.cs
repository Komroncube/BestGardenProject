using BestGarden.Application.UseCases.Orders.Commands.CreateOrder;
using BestGarden.Application.UseCases.Orders.Commands.UpdateOrderStatus;
using BestGarden.Application.UseCases.Orders.Queries.GetOrderList;
using BestGarden.Application.UseCases.Orders.Queries.GetOrderStatus;

namespace BestGarden.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrdersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrders()
    {
        var getOrdersQuery = new GetOrderListQuery();
        var orders = await _mediator.Send(getOrdersQuery);

        return Ok(orders);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderStatus(int orderId)
    {
        var getOrderStatusQuery = new GetOrderStatusQuery { OrderId = orderId };
        var orderStatus = await _mediator.Send(getOrderStatusQuery);

        return Ok(orderStatus);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromForm] CreateOrderCommand orderCommand)
    {
        var order = await _mediator.Send(orderCommand);

        return Ok(order);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateOrderStatus([FromForm] UpdateOrderStatusCommand orderCommand)
    {
        var order = await _mediator.Send(orderCommand);

        return Ok(order);
    }
}
