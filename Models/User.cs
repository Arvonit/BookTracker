using System.ComponentModel.DataAnnotations;

namespace BookTracker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}