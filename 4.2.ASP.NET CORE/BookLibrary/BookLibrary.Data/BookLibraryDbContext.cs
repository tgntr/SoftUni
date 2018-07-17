using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Data
{
    public class BookLibraryDbContext : DbContext
    {
        public BookLibraryDbContext(DbContextOptions<BookLibraryDbContext> options)
            : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Borrower> Borrowers { get; set; }

        public DbSet<BorrowedBooks> BorrowedBooks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<Book>()
                .HasMany(b => b.Borrowers)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookId);

            modelBuilder
                .Entity<Borrower>()
                .HasMany(b => b.BorrowedBooks)
                .WithOne(b => b.Borrower)
                .HasForeignKey(b => b.BorrowerId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
