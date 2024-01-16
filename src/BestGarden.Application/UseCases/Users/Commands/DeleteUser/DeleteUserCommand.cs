namespace BestGarden.Application.UseCases.Users.Commands.DeleteUser;
public class DeleteUserCommand : ICommand<bool>
{
    public int Id { get; set; }
}
