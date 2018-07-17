using BookLibrary.Data;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Web.Pages.Shared
{
    public abstract class BasePageModel : PageModel
    {
        public BasePageModel(BookLibraryDbContext context)
        {
            this.Context = context;
        }

        public BookLibraryDbContext Context { get; set; }

        protected int GetAuthorId(string authorName)
        {
            var author = this.Context.Authors.FirstOrDefault(a => a.Name == authorName);
            if (author is null)
            {
                author = new Author() { Name = authorName };
                this.Context.Authors.Add(author);
                this.Context.SaveChanges();
            }
            return author.Id;
        }

        protected bool IsBorrowed(int id)
        {
            var borrows = this.Context.BorrowedBooks.Where(b => b.BookId == id);

            return borrows.Any();
        }
    }
}
