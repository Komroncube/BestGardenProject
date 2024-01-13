using BestGarden.Domain.Enums;

namespace BestGarden.Domain.Models;
public class User : BaseDomainEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public LoyaltyStatus LoyaltyDiscountStatus { get; set; } = LoyaltyStatus.None;
    public bool IsAdmin { get; set; } = false;

    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<BasketItem> BasketItems { get; set; }
}
