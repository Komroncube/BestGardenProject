namespace BestGarden.Application.UseCases.Users.Queries.GetUserByEmail;
public class GetUserByEmailQueryHandler : IQueryHandler<GetUserByEmailQuery, User>
{
    private readonly IUserRepository _userRepository;

    public GetUserByEmailQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<User> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
    {
        return _userRepository.GetUserByEmailAsync(request.Email, cancellationToken);
    }
}
