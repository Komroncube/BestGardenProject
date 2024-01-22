namespace AuthService.Models;
public class UserDTO
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public int LoyaltyDiscountStatus { get; set; } = 0;
    public decimal TotalSpent { get; set; } = 0;
}
