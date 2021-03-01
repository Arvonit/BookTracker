using System;
using System.ComponentModel.DataAnnotations;

namespace BookTracker.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string Publisher { get; set; }
        [DataType(DataType.Date)]
        public DateTime YearPublished { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        // public int BookshelfId { get; set; }
    }
}