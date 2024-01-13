using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BestGarden.Application.UseCases.Users.Commands.UpdateUser;
public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, User>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            User user = await _userRepository.GetAsync(request.Id, cancellationToken);
            if (user is null)
            {
                throw new Exception("User not found");
            }
            _mapper.Map(request.UserDto, user);
            return await _userRepository.UpdateAsync(user, cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
