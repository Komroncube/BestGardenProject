﻿namespace AuthService.Models;

public class RegisterUserDto
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
