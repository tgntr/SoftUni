using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Web.Models;
using BookLibrary.Web.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages
{
    public class AuthorDetailsModel : BasePageModel
    {
        public AuthorDetailsModel(BookLibraryDbContext context)
            : base(context)
        {
        }

        public string Author { get; set; }

        public List<BookViewModel> Books { get; set; }

        public IActionResult OnGet(int id)
        {
            var author = this.Context.Authors.Include(a=>a.Books).FirstOrDefault(a => a.Id == id);

            if (author is null)
            {
                return NotFound();
            }

            this.Author = author.Name;

            Books = this.Context.Books
                .Where(b=>b.AuthorId == id)
                .Include(b=>b.Status)
                .Select(BookViewModel.ToBookViewModel)
                .ToList();

            return this.Page();
        }
    }
}