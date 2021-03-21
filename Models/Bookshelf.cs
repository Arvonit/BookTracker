using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace BookTracker.Models
{
    public class Bookshelf
    {
        public int Id { get; private set; }
        
        [MaxLength(100)]
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; } = null!;

        // This constructor is needed because EF Core is stupid and thinks the optional books
        // collection is required and refuses to bind to it
        public Bookshelf(int id, string name) : this(id, name, null) {}
        
        public Bookshelf(int id, string name, IEnumerable<Book>? books = null) : this(name, books)
        {
            Id = id;
        }
        
        public Bookshelf(string name, IEnumerable<Book>? books = null)
        {
            Name = name;
            // A collection navigation property should never be null
            Books = books ?? new List<Book>();
        }

        public BookshelfDto ToDto()
        {
            // Convert each book in a bookshelf to a DTO
            var dtoBooks = Books.Select(book => book.ToDto())
                .ToList();
            return new BookshelfDto(Id, Name, dtoBooks);
        }
    }
}