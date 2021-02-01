using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Wallet_Alpha.Models
{
    public class User
    {
        public User()
        {
            ID = new Guid();
        }

        [Required]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        public string Password { get; set; }

        [Required]
        public int Balance { get; set; }
        public List<Transiction> Transictions { get; set; } = new List<Transiction>();
    }
}
