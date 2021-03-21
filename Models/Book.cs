using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTracker.Models
{
    public class Book
    {
        /// <remarks>
        /// Any variable with the name `Id` or `TypeId` is automatically configured as the primary
        /// key.
        /// </remarks>
        public int Id { get; private set; }
        
        [MaxLength(100)]
        public string Title { get; set; }
        
        [MaxLength(200)]
        public string? Author { get; set; }

        [MaxLength(13)]
        public string? Isbn { get; set; }
        
        [MaxLength(100)]
        public string? Publisher { get; set; }
        
        /// <remarks>
        /// We are storing this as <c>date</c> in the database because we do not need to store the
        /// time.
        /// </remarks>
        [Column(TypeName = "date")] 
        public DateTime? PublicationDate { get; set; }
        
        public int BookshelfId { get; set; }

        public Bookshelf Bookshelf { get; set; } = null!;

        public Book(
            int id,
            int bookshelfId,
            string title,
            string? author = null,
            string? isbn = null,
            string? publisher = null,
            DateTime? publicationDate = null
        ) : this(bookshelfId, title, author, isbn, publisher, publicationDate)
        {
            Id = id;
        }
        
        // We need to have constructors because C# does not support checking block initialization to
        // see if non-nullable properties were initialized
        public Book(
            int bookshelfId,
            string title,
            string? author = null,
            string? isbn = null,
            string? publisher = null,
            DateTime? publicationDate = null
        )
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Publisher = publisher;
            PublicationDate = publicationDate;
            BookshelfId = bookshelfId;
        }

        public BookDto ToDto()
        {
            return new BookDto(
                Id,
                BookshelfId,
                Title,
                Author,
                Isbn,
                Publisher,
                PublicationDate
            );
        }

        // TODO: Write validation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
        
        private ValidationResult ValidateIsbn()
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            return
                $"Book(Id: {Id}, BookshelfId: {BookshelfId}, Title: {Title}, Author: {Author})";
        }
    }
}