using System.Collections.Generic;
using System.Linq;
using BookTracker.Data;
using BookTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookTrackerContext context;

        public BookController(BookTrackerContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return context.Books.ToList();
        }
    }
}