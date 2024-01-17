namespace BestGarden.Application.UseCases.Baskets.Commands.UpdateBasketItem;
public class UpdateBasketItemCommand : ICommand<BasketItem>
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
