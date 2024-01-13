namespace BestGarden.Application.UseCases.Users.Queries.GetUserDetail;

public class GetUserByIdQuery : IQuery<User>
{
    public int Id { get; set; }
}
