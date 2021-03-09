using System;

namespace BookTracker.Models
{
    /// <summary>
    /// A Data Transfer Object that represents our Book model.
    /// </summary>
    public class BookDto
    {
        public int Id { get; }
        public string Title { get; }
        public string? Author { get; }
        public string? Isbn { get; }
        public string? Publisher { get; }
        public DateTime? PublicationDate { get; }
        public int BookshelfId { get; }
        public string BookshelfName { get; }

        public BookDto(
            int id,
            int bookshelfId,
            string bookshelfName,
            string title,
            string? author = null,
            string? isbn = null,
            string? publisher = null,
            DateTime? publicationDate = null
        )
        {
            Id = id;
            BookshelfId = bookshelfId;
            BookshelfName = bookshelfName;
            Title = title;
            Author = author;
            Isbn = isbn;
            Publisher = publisher;
            PublicationDate = publicationDate;
        }
    }
}