using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Web.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

        public string Author { get; set; }

        public string Status { get; set; }

        public static Func<Book, BookViewModel> ToBookViewModel => b => new BookViewModel()
        {
            Title = b.Title,
            BookId = b.Id,
            Author = b.Author.Name,
            AuthorId = b.AuthorId,
            Status = b.Status.Name
        };
    }
}
