using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Chushka.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
