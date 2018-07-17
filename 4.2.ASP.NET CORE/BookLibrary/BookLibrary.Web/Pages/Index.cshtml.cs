using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using BookLibrary.Web.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Pages
{
    public class IndexModel : BasePageModel
    {
        public IndexModel(BookLibraryDbContext context)
            : base(context)
        {
        }

        public List<BookViewModel> Books { get; set; }
        public void OnGet()
        {
            this.Books = this.Context.Books
                .Include(b=>b.Author)
                .Include(b=>b.Status)
                .Select(BookViewModel.ToBookViewModel)
                .ToList();
        }
    }
}
