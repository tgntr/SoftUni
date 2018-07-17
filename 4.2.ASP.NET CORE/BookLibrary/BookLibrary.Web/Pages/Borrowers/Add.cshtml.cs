using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Web.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Web.Pages.Borrowers
{
    public class AddBorrowerModel : BasePageModel
    {
        public AddBorrowerModel(BookLibraryDbContext context)
            :base(context)
        {

        }

        [BindProperty]
        [Required]
        public string Name { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                this.ViewData["ErrorMessage"] = "Name is required";
                return this.Page();
            }

            this.Context.Borrowers.Add(new Borrower() { Name = this.Name });
            this.Context.SaveChanges();

            return this.RedirectToPage("/Index");
        }
    }
}