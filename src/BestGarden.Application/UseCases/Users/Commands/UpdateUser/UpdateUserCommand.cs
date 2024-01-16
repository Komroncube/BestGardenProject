using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Commands.UpdateUser;
public class UpdateUserCommand : ICommand<User>
{
    public int Id { get; set; }
    public UserDTO UserDto { get; set; }
}
