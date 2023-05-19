﻿namespace Equb.Dtos
{
    public class UserCreateDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; } = null;
        public string? Password { get; set; }
    }
}