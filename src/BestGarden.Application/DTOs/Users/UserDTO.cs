using BestGarden.Domain.Enums;

namespace BestGarden.Application.DTOs.Users;
public class UserDTO
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public LoyaltyStatus LoyaltyDiscountStatus { get; set; } = LoyaltyStatus.None;
    public bool IsAdmin { get; set; }
}
