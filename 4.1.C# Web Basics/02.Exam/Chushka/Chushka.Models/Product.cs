using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Chushka.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public Type Type { get; set; }

        public int TypeId { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
