using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Web.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages.Books
{
    public class BookDetailsModel : BasePageModel
    {

        public BookDetailsModel(BookLibraryDbContext context)
            :base(context)
        {
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public int AuthorId { get; set; }

        public string ImageUrl { get; set; }
        
        public string Description { get; set; }

        public int StatusId { get; set; }

        public int BookId { get; set; }

        public IActionResult OnGet(int id)
        {
            var book = this.Context.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);

            if (book is null)
            {
                return NotFound();
            }

            this.BookId = book.Id;

            this.StatusId = book.StatusId;

            this.Title = book.Title;

            this.Author = book.Author.Name;

            this.AuthorId = book.AuthorId;

            this.ImageUrl = book.Cover;

            this.Description = book.Description;

            return this.Page();
        }
    }
}