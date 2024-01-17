using BestGarden.Application.DTOs.Users;

namespace BestGarden.Application.UseCases.Users.Queries.GetUserDetail;
public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserDTO>
{
    private readonly IUserRepository _userRepository;

    public GetUserByIdQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDTO> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetAsync(request.Id, cancellationToken);
        if (user is null)
        {
            throw new Exception(nameof(User));
        }
        var userDto = new UserDTO()
        {
            FullName = user.FullName,
            LoyaltyDiscountStatus = user.LoyaltyDiscountStatus,
            Email = user.Email,
            Password = user.Password,
            PhoneNumber = user.PhoneNumber,
            TotalSpent = user.Orders.Sum(order => order.OrderItems.Sum(orderItem => orderItem.Price * orderItem.Quantity)),

        };
        return userDto;
    }
}
