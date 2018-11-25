using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Chushka.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Product Product { get; set; }

        public int ProductId { get; set; }

        [Required]
        public User Client { get; set; }

        public int ClientId { get; set; }

        [Required]
        public DateTime OrderedOn { get; set; }
    }
}
