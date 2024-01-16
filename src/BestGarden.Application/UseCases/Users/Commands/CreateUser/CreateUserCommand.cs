using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Commands.CreateUser;
public class CreateUserCommand : ICommand<User>
{
    public UserDTO UserDto { get; set; }
}
