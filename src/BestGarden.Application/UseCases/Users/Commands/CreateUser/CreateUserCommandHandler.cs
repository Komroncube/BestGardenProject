namespace BestGarden.Application.UseCases.Users.Commands.CreateUser;
public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, User>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User user = _mapper.Map<User>(request.UserDto);
        try
        {
            //password hashing

            return _userRepository.AddAsync(user, cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
