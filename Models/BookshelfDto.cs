using System.Collections.Generic;

namespace BookTracker.Models
{
    /// <summary>
    /// A Data Transfer Object that represents our Bookshelf model.
    /// </summary>
    public class BookshelfDto
    {
        public int Id { get; }
        public string Name { get; }
        public ICollection<BookDto> Books { get; }

        public BookshelfDto(int id, string name, ICollection<BookDto>? books = null)
        {
            Id = id;
            Name = name;
            Books = books ?? new List<BookDto>();
        }
    }
}