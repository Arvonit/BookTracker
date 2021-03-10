using System;

namespace BookTracker.Models
{
    /// <summary>
    /// A Data Transfer Object that represents our Book model.
    /// </summary>
    public class BookDto
    {
        public int? Id { get; }
        public string Title { get; }
        public string? Author { get; }
        public string? Isbn { get; }
        public string? Publisher { get; }
        public DateTime? PublicationDate { get; }
        public int BookshelfId { get; }

        public BookDto(
            int? id,
            int bookshelfId,
            string title,
            string? author = null,
            string? isbn = null,
            string? publisher = null,
            DateTime? publicationDate = null
        )
        {
            Id = id;
            BookshelfId = bookshelfId;
            Title = title;
            Author = author;
            Isbn = isbn;
            Publisher = publisher;
            PublicationDate = publicationDate;
        }

        public Book ToModel()
        {
            return new Book(Id, BookshelfId, Title, Author, Isbn, Publisher, PublicationDate);
        }

        // TODO: Finish
        public override string ToString()
        {
            return
                $"BookDto(Id: {Id}, BookshelfId: {BookshelfId}, Title: {Title}, Author: {Author})";
        }
    }
}