namespace BestGarden.Application.Contracts;
public interface IUserRepository : IGenericRepository<User>
{
    Task<User> GetUserByEmailAsync(string email, CancellationToken cancellationToken);
}
