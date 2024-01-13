using AutoMapper;
using BestGarden.Application.DTOs.Users;
using BestGarden.Application.UseCases.Users.Commands.CreateUser;

namespace BestGarden.Application.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDTO>().ReverseMap();

    }
}
