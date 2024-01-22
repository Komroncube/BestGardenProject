using AuthService.Models;
using BestGarden.Application.DTOs.Users;
using Refit;

namespace AuthService;

public interface IBestGardenAPI
{
    [Post("/api/Users")]
    Task<UserDTO> CreateUserAsync(UserDTO command, CancellationToken cancellationToken);

    [Post("/api/Users/authentication")]
    Task<UserDTO> GetUserByEmailAsync(AuthenticationRequest authenticationRequest, CancellationToken cancellationToken);
}
