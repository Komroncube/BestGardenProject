using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BestGarden.Application.UseCases.Catalogs.Commands.CreateCatalog;
public class CreateCatalogCommandHandler : ICommandHandler<CreateCatalogCommand, Catalog>
{
    private readonly ICatalogRepository _catalogRepository;
    private readonly IMapper _mapper;

    public CreateCatalogCommandHandler(ICatalogRepository catalogRepository, IMapper mapper)
    {
        _catalogRepository = catalogRepository;
        _mapper = mapper;
    }

    public async Task<Catalog> Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var catalog = _mapper.Map<Catalog>(request.CatalogCreateDto); 
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
