using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Commands.AuthenticateUser;
public class AuthenticateUserCommandHandler //: ICommandHandler<AuthenticateUserCommand, AuthenticationResponse>
{
    private readonly IUserRepository _userRepository;

    public AuthenticateUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<AuthenticationResponse> Handle(AuthenticateUserCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new AuthenticationResponse());
    }
}
