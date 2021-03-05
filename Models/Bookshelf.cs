using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookTracker.Models
{
    public class Bookshelf
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; }
        
        // public ICollection<Book> Books { get; set; }

        public Bookshelf(string name)
        {
            Name = name;
        }
    }
}