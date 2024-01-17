using BestGarden.Domain.Enums;

namespace BestGarden.Application.UseCases.Users.Notifications.OrderCreated;
public class OrderDeliveredNotificationHandler : INotificationHandler<OrderDeliveredNotification>
{
    private readonly IUserRepository _userRepository;

    public OrderDeliveredNotificationHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task Handle(OrderDeliveredNotification notification, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetAsync(notification.UserId, cancellationToken);
        var totalPrice = user.Orders.Where(x => x.OrderStatus == OrderStatus.Completed)
                                            .Sum(order => order.OrderItems.Sum(orderItem => orderItem.Price * orderItem.Quantity));

        // Determine the loyalty discount status based on the total price
        // and update the user's loyalty discount status accordingly.
        // The loyalty discount status is an enum that represents different levels of loyalty.
        // - If the total price is less than 10,000,000, the loyalty discount status is set to None.
        // - If the total price is less than 15,000,000, the loyalty discount status is set to Bronze.
        // - If the total price is less than 18,000,000, the loyalty discount status is set to Silver.
        // - If the total price is less than 20,000,000, the loyalty discount status is set to Gold.
        // - If the total price is 20,000,000 or more, the loyalty discount status is set to Platinum.
        // After updating the loyalty discount status, clear the user's basket items.

        switch (totalPrice)
        {
            case < 10_000_000:
                user.LoyaltyDiscountStatus = LoyaltyStatus.None;
                break;
            case < 15_000_000:
                user.LoyaltyDiscountStatus = LoyaltyStatus.Bronze;
                break;
            case < 18_000_000:
                user.LoyaltyDiscountStatus = LoyaltyStatus.Silver;
                break;
            case < 20_000_000:
                user.LoyaltyDiscountStatus = LoyaltyStatus.Gold;
                break;
            default:
                user.LoyaltyDiscountStatus = LoyaltyStatus.Platinum;
                break;
        }

        await _userRepository.UpdateAsync(user, cancellationToken);

    }
}
