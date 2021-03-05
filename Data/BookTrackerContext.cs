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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Unfortunately, there is no way to specify a default SQL value as an annotation,
            // so we must do with the Fluent API.
            modelBuilder.Entity<Book>()
                .Property(book => book.DateCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Book>()
                .Property(book => book.DateModified)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}