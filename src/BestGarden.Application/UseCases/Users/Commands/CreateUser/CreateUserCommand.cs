using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestGarden.Application.DTOs.Users;
using BestGarden.Domain.Enums;

namespace BestGarden.Application.UseCases.Users.Commands.CreateUser;
public class CreateUserCommand : ICommand<User>
{
    public UserDTO UserDto { get; set; }
}
