namespace BestGarden.Application.UseCases.Users.Queries.GetUserList;

public class GetUserListQueryHandler : IQueryHandler<GetUserListQuery, IReadOnlyList<User>>
{
    private readonly IUserRepository _userRepository;

    public GetUserListQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<IReadOnlyList<User>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
    {
        return _userRepository.GetAllAsync(cancellationToken);
    }
}
