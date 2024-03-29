﻿using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Data
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}