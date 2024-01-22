using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Commands.AuthenticateUser;
public class AuthenticateUserCommand : ICommand<AuthenticationResponse>
{
    public AuthenticationRequest AuthRequest { get; set; }
}
