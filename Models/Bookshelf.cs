using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BookTracker.Models
{
    public class Bookshelf
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; }
        
        public ICollection<Book> Books { get; }

        public Bookshelf(int id, string name) : this(name)
        {
            Id = id;
        }
        
        public Bookshelf(string name, ICollection<Book>? books = null)
        {
            Name = name;
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