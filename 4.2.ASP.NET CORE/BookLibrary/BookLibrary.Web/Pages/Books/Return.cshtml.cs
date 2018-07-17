using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Web.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Web.Pages.Books
{
    public class ReturnModel : BasePageModel 
    {
        public ReturnModel(BookLibraryDbContext context)
            :base (context)
        {

        }

        public IActionResult OnGet(int id)
        {
            var book = this.Context.Books.FirstOrDefault(b => b.Id == id);

            if (book.StatusId == 1)
            {
                this.ViewData["ErrorMessage"] = "Book not borrowed";
                return this.Page();
            }

            book.StatusId = 1;

            var lastBorrow = this.Context.BorrowedBooks.Last(b => b.BookId == id);
            lastBorrow.ReturnDate = DateTime.Now;
            this.Context.SaveChanges();
            return this.RedirectToPage("/Index");
        }
    }
}