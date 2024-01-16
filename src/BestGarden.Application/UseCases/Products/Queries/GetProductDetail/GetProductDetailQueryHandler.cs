namespace BestGarden.Application.UseCases.Products.Queries.GetProductDetail;
public class GetProductDetailQueryHandler : IQueryHandler<GetProductDetailQuery, Product>
{
    private readonly IProductRepository _productRepository;

    public GetProductDetailQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<Product> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
    {
        return _productRepository.GetAsync(request.Id, cancellationToken);
    }
}
