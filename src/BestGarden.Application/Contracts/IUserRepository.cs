using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.Contracts;
public interface IUserRepository : IGenericRepository<User>
{
    Task<User> GetUserByEmailAsync(string email, CancellationToken cancellationToken);
    Task<User> AuthenticateAsync(AuthenticationRequest request, CancellationToken cancellationToken);
}
