using BestGarden.Domain.Enums;

namespace BestGarden.Application.DTOs.Users;
public class UserDTO
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public LoyaltyStatus LoyaltyDiscountStatus { get; set; } = LoyaltyStatus.None;
    public decimal TotalSpent { get; set; }
}
