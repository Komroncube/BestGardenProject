namespace BestGarden.Application.UseCases.Baskets.Commands.UpdateBasketItem;
public class UpdateBasketItemCommandHandler : ICommandHandler<UpdateBasketItemCommand, BasketItem>
{
    private readonly IBasketItemRepository _basketRepository;

    public UpdateBasketItemCommandHandler(IBasketItemRepository basketRepository)
    {
        _basketRepository = basketRepository;
    }

    public async Task<BasketItem> Handle(UpdateBasketItemCommand request, CancellationToken cancellationToken)
    {
        try
        {
            int userId = 2;
            BasketItem basketItem = await _basketRepository.GetBasketItemByUserIdAsync(2, request.ProductId, cancellationToken);
            if (basketItem is null)
            {
                throw new Exception("Basket item not found");
            }
            basketItem.Quantity = request.Quantity;
            return await _basketRepository.UpdateAsync(basketItem, cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
