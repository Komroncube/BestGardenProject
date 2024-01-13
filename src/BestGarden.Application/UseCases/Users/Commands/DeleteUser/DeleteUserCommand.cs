using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGarden.Application.UseCases.Users.Commands.DeleteUser;
public class DeleteUserCommand : ICommand<bool>
{
    public int Id { get; set; }
}
