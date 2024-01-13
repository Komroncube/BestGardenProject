using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BestGarden.Application.DTOs.Users;
using BestGarden.Domain.Enums;

namespace BestGarden.Application.UseCases.Users.Commands.UpdateUser;
public class UpdateUserCommand : ICommand<User>
{
    public int Id { get; set; }
    public UserDTO UserDto { get; set; }
}
