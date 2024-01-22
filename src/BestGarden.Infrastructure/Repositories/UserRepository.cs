using BestGarden.Application.DTOs.Users;
using Microsoft.EntityFrameworkCore;

namespace BestGarden.Infrastructure.Repositories;

internal class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly ApplicationDbContext _dbContext;
    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<User> GetUserByEmailAsync(string email, CancellationToken cancellationToken)
    {
        return _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
    }

    public Task<User> AuthenticateAsync(AuthenticationRequest request, CancellationToken cancellationToken)
    {
        return _dbContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email && u.Password == request.Password, cancellationToken);
    }
}
