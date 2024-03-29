﻿using System.ComponentModel.DataAnnotations;

namespace acadamy_2024.Controllers.Models
{
    public class User
    {
        [Required]
        public int? Id { get; set; }
        [StringLength(10)]
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }
    }
}
