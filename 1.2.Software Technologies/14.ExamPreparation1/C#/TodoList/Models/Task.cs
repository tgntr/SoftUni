using System.Web.Mvc;
using Microsoft.Build.Framework;

namespace TodoList.Models
{
    public class Task
    {
        public int Id { get; set; }
            
        public string Title { get; set; }

        [Required]
        public string Comments { get; set; }


    }
}