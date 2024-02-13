using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Queries.GetUserDetail;
public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserDTO>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserDTO> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetAsync(request.Id, cancellationToken);
        if (user is null)
        {
            throw new Exception(nameof(User));
        }
        var userDto = _mapper.Map<UserDTO>(user);
        return userDto;
    }
}
