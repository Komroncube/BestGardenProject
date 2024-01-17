namespace BestGarden.Application.UseCases.Users.Queries.GetUserByEmail;
public class GetUserByEmailQuery : IQuery<User>
{
    public string Email { get; set; }
}
