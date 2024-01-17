namespace BestGarden.Application.UseCases.Baskets.Commands.CreateBasketItem;
public class CreateBasketItemCommand : ICommand<BasketItem>
{
    public int ProductId { get; set; }
}
