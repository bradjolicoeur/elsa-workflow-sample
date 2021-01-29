﻿using System.ComponentModel.DataAnnotations;

namespace elsa_blazor.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
    }
}
