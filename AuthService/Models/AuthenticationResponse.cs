namespace BestGarden.Application.DTOs.Users;
public class AuthenticationResponse
{
    public int Id { get; set; }
    public string Token { get; set; }
    // public string RefreshToken { get; set; }
    public string Email { get; set; }
}
