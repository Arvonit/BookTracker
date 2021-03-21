using System.Collections.Generic;
using System.Linq;

namespace BookTracker.Models
{
    /// <summary>
    /// A Data Transfer Object that represents our Bookshelf model.
    /// </summary>
    public class BookshelfDto
    {
        public int? Id { get; private set; }
        public string Name { get; set; }
        public ICollection<BookDto> Books { get; }

        public BookshelfDto(int? id, string name, ICollection<BookDto>? books = null)
        {
            Id = id;
            Name = name;
            Books = books ?? new List<BookDto>();
        }

        public Bookshelf ToModel()
        {
            var books = Books.Select(bookDto => bookDto.ToModel()).ToList();
            if (Id is int id)
            {
                return new Bookshelf(id, Name, books);
            }
            else
            {
                return new Bookshelf(Name, books);
            }
        }
    }
}