using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Queries.GetUserDetail;

public class GetUserByIdQuery : IQuery<UserDTO>
{
    public int Id { get; set; }
}
