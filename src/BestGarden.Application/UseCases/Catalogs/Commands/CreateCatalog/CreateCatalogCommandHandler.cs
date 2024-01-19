using BestGarden.Application.Services;

namespace BestGarden.Application.UseCases.Catalogs.Commands.CreateCatalog;
public class CreateCatalogCommandHandler : ICommandHandler<CreateCatalogCommand, Catalog>
{
    private readonly ICatalogRepository _catalogRepository;
    private readonly IMapper _mapper;
    private readonly IFileService _fileService;


    public CreateCatalogCommandHandler(ICatalogRepository catalogRepository, IMapper mapper, IFileService fileService)
    {
        _catalogRepository = catalogRepository;
        _mapper = mapper;
        _fileService = fileService;
    }

    public async Task<Catalog> Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var catalog = _mapper.Map<Catalog>(request.CatalogCreateDto);
            catalog.ImagePath = await _fileService.SaveFileAsync(request.CatalogCreateDto.Image);
            await _catalogRepository.AddAsync(catalog, cancellationToken);
            return catalog;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
