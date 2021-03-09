using System;
using System.Collections.Generic;
using System.Linq;
using BookTracker.Data;
using BookTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Controllers
{
    // TODO: Replace model with DTO
    // TODO: Make everything async
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookTrackerContext context;

        public BookController(BookTrackerContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets all the books from the database.
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return context.Books
                .ToList();
        }

        /// <summary>
        /// Gets a book based on its id.
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = context.Books.Find(id);
            if (book is null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        /// <summary>
        /// Adds a book.
        /// </summary>
        [HttpPost]
        public ActionResult<Book> AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();

            // We return a 201 status code with:
            // 1. The name of the GET request to call to retrieve this new book
            // 2. The parameters to pass into that get request (i.e. the book's id)
            // 3. The newly added book itself
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        /// <summary>
        /// Update a book with the given id and updated book object.
        /// </summary>
        [HttpPut("{id}")]
        public ActionResult<Book> UpdateBook(int id, Book book)
        {
            Console.WriteLine("We started processing this book.");
            if (id != book.Id)
            {
                return BadRequest();
            }

            // Tell Entity Framework that we have modified the book so that we can persist the
            // changes.
            context.Attach(book).State = EntityState.Modified;
            context.SaveChanges();

            return Ok(book);
        }

        /// <summary>
        /// Deletes a book based on the given id.
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult RemoveBook(int id)
        {
            var book = context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            context.Books.Remove(book);
            context.SaveChanges();
            
            // We typically return a 204 status code when an action has been completed successfully,
            // but we do not need to return anything back. In this case, we are deleting a book so
            // there is no point in returning a deleted book.
            return NoContent();
        }
    }
}