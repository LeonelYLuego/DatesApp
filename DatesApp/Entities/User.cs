﻿using System.ComponentModel.DataAnnotations;

namespace DatesApp.Entities
{
    public class User
    {
        public int Id { get; set; }

        public required string Username { get; set; }

        public required string Email { get; set; }

        public required byte[] PasswordHash { get; set; }

        public required byte[] PasswordSalt { get; set; }
    }
}
