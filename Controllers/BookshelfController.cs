using System.Collections.Generic;
using System.Linq;
using BookTracker.Data;
using BookTracker.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Controllers
{
    [EnableCors("TestPolicy")]
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
        public ActionResult<IEnumerable<BookshelfDto>> GetBookshelves()
        {
            return context.Bookshelves
                .Include(bookshelf => bookshelf.Books) // Query relational data
                .Select(bookshelf => bookshelf.ToDto())
                .ToList();
        }
    
        [HttpGet("{id}")]
        public ActionResult<BookshelfDto> GetBookshelf(int id)
        {
            var bookshelf = context.Bookshelves
                .Where(item => item.Id == id)
                .Include(item => item.Books)
                .First();
            if (bookshelf is null)
            {
                return NotFound();
            }
            
            return bookshelf.ToDto();
        }
        
        /// <summary>
        /// Adds a bookshelf.
        /// </summary>
        [HttpPost]
        public ActionResult<Bookshelf> AddBookshelf(BookshelfDto bookshelfDto)
        {
            var bookshelf = bookshelfDto.ToModel();
            context.Bookshelves.Add(bookshelf);
            context.SaveChanges();

            // We return a 201 status code with:
            // 1. The name of the GET request to call to retrieve this new book
            // 2. The parameters to pass into that get request (i.e. the bookshelf's id)
            // 3. The newly added bookshelf itself
            return CreatedAtAction(nameof(GetBookshelf), new { id = bookshelf.Id }, bookshelf);
        }
        
        // <summary>
        /// Deletes a bookshelf based on the given id.
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult RemoveBookshelf(int id)
        {
            var bookshelf = context.Bookshelves.Find(id);
            if (bookshelf is null)
            {
                return NotFound();
            }

            context.Bookshelves.Remove(bookshelf);
            context.SaveChanges();
            
            // We typically return a 204 status code when an action has been completed successfully,
            // but we do not need to return anything back. In this case, we are deleting a bookshelf
            // so there is no point in returning a deleted book.
            return NoContent();
        }
    }
}