using System;
using BookTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Data
{
    public class BookTrackerContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Bookshelf> Bookshelves => Set<Bookshelf>();
        
        public BookTrackerContext(DbContextOptions<BookTrackerContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add Bookshelf seed data
            modelBuilder.Entity<Bookshelf>().HasData(
                new Bookshelf(1, "Want to Read"),
                new Bookshelf(2, "Currently Reading"),
                new Bookshelf(3, "Read")
            );
            
            // Add Book seed data
            modelBuilder.Entity<Book>().HasData(
                new Book(
                    1,
                    1,
                    "The Adventures of Huckleberry Finn",
                    "Mark Twain",
                    "0142437174",
                    "Penguin Classics",
                    DateTime.Parse("1884-12-01")
                ),
                new Book(
                    2,
                    2,
                    "To Kill a Mockingbird",
                    "Harper Lee",
                    "0123456789",
                    "Harper Perennial Modern Classics",
                    DateTime.Parse("1960-07-11")
                ),
                new Book(
                    3,
                    3,
                    "Programming Windows",
                    "Charles Petzold",
                    "9781572319950",
                    "Microsoft Press",
                    DateTime.Parse("1998-12-01")
                )
            );
        }
    }
}