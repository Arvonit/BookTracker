using System.Collections.Generic;
using System.Linq;
using BookTracker.Data;
using BookTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookshelfController : ControllerBase
    {
        private readonly BookTrackerContext context;
    
        public BookshelfController(BookTrackerContext context)
        {
            this.context = context;
        }
    
        [HttpGet]
        public ActionResult<IEnumerable<Bookshelf>> GetBookshelves()
        {
            return context.Bookshelves
                .Include(bookshelf => bookshelf.Books) // Query relational data
                .ToList();
        }
    
        [HttpGet("{id}")]
        public ActionResult<Bookshelf> GetBookshelf(int id)
        {
            var bookshelf = context.Bookshelves
                .Where(item => item.Id == id)
                .Include(item => item.Books)
                .First();
            if (bookshelf is null)
            {
                return NotFound();
            }
            
            return bookshelf;
        }
        
        /// <summary>
        /// Adds a bookshelf.
        /// </summary>
        [HttpPost]
        public ActionResult<Bookshelf> AddBookshelf(Bookshelf bookshelf)
        {
            context.Bookshelves.Add(bookshelf);
            context.SaveChanges();

            // We return a 201 status code with:
            // 1. The name of the GET request to call to retrieve this new book
            // 2. The parameters to pass into that get request (i.e. the bookshelf's id)
            // 3. The newly added bookshelf itself
            return CreatedAtAction(nameof(GetBookshelf), new { id = bookshelf.Id }, bookshelf);
        }
    }
}