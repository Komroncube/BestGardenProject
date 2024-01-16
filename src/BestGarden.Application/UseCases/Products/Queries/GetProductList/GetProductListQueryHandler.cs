using BestGarden.Application.DTOs.Products;

namespace BestGarden.Application.UseCases.Products.Queries.GetProductList;
public class GetProductListQueryHandler : IQueryHandler<GetProductListQuery, IEnumerable<ProductListDTO>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductListQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductListDTO>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
    {
        IReadOnlyList<Product> products = await _productRepository.GetAllAsync(cancellationToken);
        return products.Select(product => _mapper.Map<ProductListDTO>(product));

    }
}
