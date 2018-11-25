using System;
using System.Collections.Generic;
using System.Text;

namespace Chushka.App.Models
{
    public class ProductBindingModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int ProductType { get; set; }
    }
}
