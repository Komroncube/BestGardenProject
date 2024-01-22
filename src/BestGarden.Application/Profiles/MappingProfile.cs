using BestGarden.Application.DTOs.Catalogs;
using BestGarden.Application.DTOs.Products;
using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDTO>()
            .ForMember(x => x.TotalSpent,
                opt => opt.
                                                                            MapFrom(x => x.Orders
                                                                                                    .Sum(order => order.OrderItems
                                                                                                        .Sum(item => item.Price * item.Quantity))));
        CreateMap<UserDTO, User>();
        CreateMap<User, UserRegisterDTO>().ReverseMap();
        CreateMap<Catalog, CatalogCreateDTO>().ReverseMap();
        CreateMap<Product, ProductListDTO>().ReverseMap();
        CreateMap<Product, ProductCreateDTO>().ReverseMap();

    }
}
