namespace BestGarden.Application.UseCases.Baskets.Commands.CreateBasketItem;
public class CreateBasketItemCommandHandler : ICommandHandler<CreateBasketItemCommand, BasketItem>
{
    private readonly IBasketItemRepository _basketRepository;

    public CreateBasketItemCommandHandler(IBasketItemRepository basketRepository)
    {
        _basketRepository = basketRepository;
    }

    public Task<BasketItem> Handle(CreateBasketItemCommand request, CancellationToken cancellationToken)
    {
        BasketItem basketItem = new()
        {
            UserId = 2,
            ProductId = request.ProductId,
        };
        try
        {
            return _basketRepository.AddAsync(basketItem, cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
