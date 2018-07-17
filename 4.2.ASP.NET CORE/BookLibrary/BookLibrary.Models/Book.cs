using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Author Author { get; set; }

        public int AuthorId { get; set; }

        public string Cover { get; set; }

        public Status Status { get; set; }

        public int StatusId { get; set; }

        public ICollection<BorrowedBooks> Borrowers { get; set; } = new List<BorrowedBooks>();
    }
}
