using AuthService.Models;

namespace AuthService.Services;
public interface IJWTService
{
    string GenerateToken(UserDTO user);

}
