using BestGarden.Application.UseCases.Baskets.Commands.CreateBasketItem;
using BestGarden.Application.UseCases.Baskets.Commands.UpdateBasketItem;
using BestGarden.Application.UseCases.Baskets.Queries.GetBasketDetail;

namespace BestGarden.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BasketItemsController : ControllerBase
{
    private readonly IMediator _mediator;

    public BasketItemsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetBasketItems()
    {
        var getBasketItemsQuery = new GetBasketDetailQuery();
        var basketItems = await _mediator.Send(getBasketItemsQuery);

        return Ok(basketItems);
    }

    [HttpPost]
    public async Task<IActionResult> AddBasketItem([FromBody] int productId)
    {
        var basketItem = await _mediator.Send(new CreateBasketItemCommand { ProductId = productId });

        return Ok(basketItem);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateBasketItem([FromBody] int productId, int quantity)
    {
        var updateBasketItemCommand = new UpdateBasketItemCommand { ProductId = productId, Quantity = quantity };
        BasketItem basketItem = await _mediator.Send(updateBasketItemCommand);
        return Ok(basketItem);
    }
}
