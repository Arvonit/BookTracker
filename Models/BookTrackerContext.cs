using Microsoft.EntityFrameworkCore;

namespace BookTracker.Models
{
    public class BookTrackerContext : DbContext
    {
        public BookTrackerContext(DbContextOptions<BookTrackerContext> options) : base(options)
        {
        }
        
        public DbSet<Book> Books { get; set; }
        // public DbSet<Bookshelf> Bookshelves { get; set; }
    }
}