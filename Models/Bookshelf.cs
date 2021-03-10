using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BookTracker.Models
{
    public class Bookshelf
    {
        public int Id { get; private set; }
        
        [MaxLength(100)]
        public string Name { get; set; }
        
        public ICollection<Book> Books { get; }

        public Bookshelf(int? id, string name, ICollection<Book>? books = null) : this(name, books)
        {
            // TODO: Refactor
            if (id.HasValue)
            {
                Id = id.Value;
            }
        }
        
        public Bookshelf(string name, ICollection<Book>? books = null)
        {
            Name = name;
            Books = books ?? new List<Book>();
        }

        public Bookshelf(int id, string name)
        {
            Id = id;
            Name = name;
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