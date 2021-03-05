using System;
using BookTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Data
{
    public class BookTrackerContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        // public DbSet<Bookshelf> Bookshelves { get; set; }
        
        public BookTrackerContext(DbContextOptions<BookTrackerContext> options) : base(options)
        {
        }
    }
}