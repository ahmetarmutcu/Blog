﻿namespace Blog.Entity.DTOs.Users
{
    public class UserLoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
