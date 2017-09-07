using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ShoppingList.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int Priority { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Status { get; set; }

    }
}