using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Queries.GetUserByEmail;
public class GetUserByEmailQuery : IQuery<UserDTO>
{
    public AuthenticationRequest Authentication { get; set; }
}
