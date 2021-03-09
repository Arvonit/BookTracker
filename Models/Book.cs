using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        
        [JsonIgnore]
        public Bookshelf Bookshelf { get; set; }

        public Book(
            int id,
            int bookshelfId,
            string title,
            string? author = null,
            string? isbn = null,
            string? publisher = null,
            DateTime? publicationDate = null
        ) : this(title, author, isbn, publisher, publicationDate)
        {
            Id = id;
            BookshelfId = bookshelfId;
        }
        
        public Book(
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
            // Bookshelf = bookshelf;
        }

        public BookDto ToDto()
        {
            return new BookDto(
                Id,
                BookshelfId,
                Bookshelf.Name,
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
    }
}