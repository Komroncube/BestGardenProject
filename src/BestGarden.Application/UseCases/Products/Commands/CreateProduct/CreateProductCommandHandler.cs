using BestGarden.Application.Services;

namespace BestGarden.Application.UseCases.Products.Commands.CreateProduct;
public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Product>
{
    private readonly IProductRepository _productRepository;
    private readonly IFileService _fileService;
    private readonly IMapper _mapper;

    public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper, IFileService fileService)
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _fileService = fileService;
    }

    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Product product = _mapper.Map<Product>(request.ProductCreateDto);
        try
        {
            product.ImagePath = await _fileService.SaveFileAsync(request.ProductCreateDto.Image);
            return await _productRepository.AddAsync(product, cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
