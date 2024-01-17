using BestGarden.Application.DTOs.BasketItems;
using BestGarden.Application.DTOs.Products;

namespace BestGarden.Application.UseCases.Baskets.Queries.GetBasketDetail;
public class GetBasketDetailQueryHandler : IQueryHandler<GetBasketDetailQuery, IEnumerable<BasketItemDTO>>
{
    private readonly IBasketItemRepository _basketRepository;
    private readonly IMapper _mapper;

    public GetBasketDetailQueryHandler(IBasketItemRepository basketRepository, IMapper mapper)
    {
        _basketRepository = basketRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BasketItemDTO>> Handle(GetBasketDetailQuery request, CancellationToken cancellationToken)
    {
        var basketItems = await _basketRepository.GetAllAsync(cancellationToken);
        var basketList = basketItems.Select(basket => new BasketItemDTO
        {
            Product = _mapper.Map<ProductListDTO>(basket.Product),
            Quantity = basket.Quantity
        });
        return basketList;
    }
}
