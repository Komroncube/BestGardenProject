using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Queries.GetUserByEmail;
public class GetUserByEmailQueryHandler : IQueryHandler<GetUserByEmailQuery, UserDTO>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUserByEmailQueryHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserDTO> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
    {
        User user = await _userRepository.AuthenticateAsync(request.Authentication, cancellationToken);
        return _mapper.Map<UserDTO>(user);
    }
}
