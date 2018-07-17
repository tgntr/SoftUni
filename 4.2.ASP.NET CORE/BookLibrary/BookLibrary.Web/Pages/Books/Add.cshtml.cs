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

namespace BookLibrary.Web.Pages.Books
{
    public class AddBookModel : BasePageModel
    {
        public AddBookModel(BookLibraryDbContext context)
            :base(context)
        {
            
        }
        [BindProperty]
        [Required]
        public string Title { get; set; }

        [BindProperty]
        [Required]
        public string Author { get; set; }

        [BindProperty]
        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; set; }

        [BindProperty]
        public string Description { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                this.ViewData["ErrorMessage"] = "Title and Author are required";
                return this.Page();
            }

            var authorId = this.GetAuthorId(this.Author);
            var book = new Book()
            {
                Title = this.Title,
                AuthorId = authorId,
                Cover = this.ImageUrl,
                Description = this.Description,
                StatusId = 1
            };

            this.Context.Books.Add(book);
            this.Context.SaveChanges();
            return this.RedirectToPage("/Books/Details", new { id = book.Id });

        }

        
    }
}