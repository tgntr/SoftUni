using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using BookLibrary.Web.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Web.Pages
{
    public class SearchModel : BasePageModel
    {
        public SearchModel(BookLibraryDbContext context)
            :base(context)
        {
            this.Results = new List<SearchViewModel>();
        }

        public List<SearchViewModel> Results { get; set; }

        //[BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public void OnGet(string searchTerm)
        {
            this.SearchTerm = searchTerm;
            var resultBooks = this.Context.Books
                .Where(b => b.Title.Contains(this.SearchTerm))
                .Select(b => new SearchViewModel()
                {
                    Name = b.Title,
                    Type = "book",
                    Url = $"/Books/Details/{b.Id}"
                });

            var resultAuthors = this.Context.Authors
                .Where(a => a.Name.Contains(this.SearchTerm))
                .Select(a => new SearchViewModel()
                {
                    Url = $"Authors/Details/{a.Id}",
                    Name = a.Name,
                    Type = "author"
                });

            this.Results.AddRange(resultBooks);
            this.Results.AddRange(resultAuthors);
            this.Results = this.Results.OrderBy(r => r.Name).ToList();
        }
    }
}