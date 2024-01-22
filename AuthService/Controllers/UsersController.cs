using AuthService.Models;
using AuthService.Services;
using BestGarden.Application.DTOs.Users;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace AuthService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IBestGardenAPI _bestGardenAPI;
    private readonly IJWTService _jwtService;

    public UsersController(IBestGardenAPI bestGardenApi, IJWTService jwtService)
    {
        _bestGardenAPI = bestGardenApi;
        _jwtService = jwtService;
    }

    [HttpPost("authorize")]
    public async ValueTask<IActionResult> Authentication(AuthenticationRequest authenticationRequest)
    {
        try
        {
            var user = await _bestGardenAPI.GetUserByEmailAsync(authenticationRequest, CancellationToken.None);
            
            var resp = new AuthenticationResponse()
            {
                Email = authenticationRequest.Email,
                Token = _jwtService.GenerateToken(user)
            };
            return Ok(resp);
        }
        catch (ApiException apiException)
        {
            Console.WriteLine(apiException);
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpPost("register")]
    public async ValueTask<IActionResult> RegisterUser(RegisterUserDto registerUserDto)
    {
        var user = new UserDTO()
        {
            Email = registerUserDto.Email,
            Password = registerUserDto.Password,
            FullName = registerUserDto.FullName,
            PhoneNumber = registerUserDto.PhoneNumber,
        };
        var userDto = await _bestGardenAPI.CreateUserAsync(user, CancellationToken.None);
        var resp = new AuthenticationResponse()
        {
            Email = registerUserDto.Email,
            Token = _jwtService.GenerateToken(userDto)
        };
        return Ok(resp);
        //return Ok(resp);
    }

    [Microsoft.AspNetCore.Authorization.Authorize]
    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok("GetUsers");
    }
}
