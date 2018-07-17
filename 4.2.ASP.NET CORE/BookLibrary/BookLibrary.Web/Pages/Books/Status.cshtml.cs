using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Web.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages.Books
{
    public class StatusModel : BasePageModel
    {
        public StatusModel(BookLibraryDbContext context)
              : base(context)
        {

        }
        public List<BorrowedBooks> Borrows { get; set; }
        public void OnGet(int id)
        {
            this.Borrows = this.Context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b=>b.Borrower)
                .Where(b => b.BookId == id)
                .OrderByDescending(b => b.ReturnDate)
                .ToList();

        }
    }
}