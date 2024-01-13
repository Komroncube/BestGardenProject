namespace BestGarden.Application.UseCases.Users.Queries.GetUserDetail;
public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, User>
{
    private readonly IUserRepository _userRepository;

    public GetUserByIdQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetAsync(request.Id, cancellationToken);
        if (user is null)
        {
            throw new Exception(nameof(User));
        }
        return user;
    }
}
