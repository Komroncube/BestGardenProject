using BestGarden.Application.DTOs.Catalogs;
using BestGarden.Application.DTOs.Products;
using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDTO>().ReverseMap();
        CreateMap<Catalog, CatalogCreateDTO>().ReverseMap();
        CreateMap<Product, ProductListDTO>().ReverseMap();
        CreateMap<Product, ProductCreateDTO>().ReverseMap();

    }
}
