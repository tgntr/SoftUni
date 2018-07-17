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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookLibrary.Web.Pages.Books
{
    public class BorrowModel : BasePageModel
    {
        public BorrowModel(BookLibraryDbContext context)
            :base(context)
        {
            this.Borrowers = this.Context.Borrowers.Select(b => new SelectListItem(b.Name, b.Id.ToString())).ToList();
            this.BorrowDate = this.DateNow;
        }

        public DateTime DateNow => DateTime.Now;

        public IEnumerable<SelectListItem> Borrowers { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "You have to specify a borrower.")]
        [Display(Name = "Borrower")]
        public int BorrowerId { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Date)]
        public DateTime BorrowDate { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                this.ViewData["ErrorMessage"] = "Please fill out the form";
                return this.Page();
            }

            var book = this.Context.Books.FirstOrDefault(b => b.Id == id);

            if (book is null || book.StatusId == 2)
            {
                this.ViewData["ErrorMessage"] = "Book is invalid or already borrowed";
                return this.Page();
            }

            if (this.ReturnDate != null && this.BorrowDate > this.ReturnDate)
            {
                this.ViewData["ErrorMessage"] = "Return Date must be later than Borrow Date";
                return this.Page();
            }

            if (this.BorrowDate.ToShortDateString() == this.DateNow.ToShortDateString())
            {
                this.BorrowDate = this.DateNow;
            }

            var borrowedBook = new BorrowedBooks()
            {
                BookId = id,
                BorrowerId = this.BorrowerId,
                BorrowDate = this.BorrowDate,
                ReturnDate = this.ReturnDate
            };

            
            book.StatusId = 2;
            this.Context.BorrowedBooks.Add(borrowedBook);
            this.Context.SaveChanges();

            return this.RedirectToPage("/Index");
            
            
        }
    }
}