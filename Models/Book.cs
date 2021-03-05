using System;
using System.ComponentModel;
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
        public int Id { get; set; }
        
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
        
        // public int BookshelfId { get; set; }
        
        // public Bookshelf Bookshelf { get; set; }

        public Book(string title)
        {
            Title = title;
        }
    }
}