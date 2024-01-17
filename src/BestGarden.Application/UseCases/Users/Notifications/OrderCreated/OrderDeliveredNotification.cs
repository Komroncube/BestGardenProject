namespace BestGarden.Application.UseCases.Users.Notifications.OrderCreated;
public class OrderDeliveredNotification : INotification
{
    public readonly int UserId;

    public OrderDeliveredNotification(int userId)
    {
        UserId = userId;
    }
}
