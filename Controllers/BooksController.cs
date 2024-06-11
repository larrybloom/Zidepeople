using BookManagementAPI.Data;
using BookManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = _repository.GetAll();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = _repository.GetById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> AddBook([FromBody] Book book)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var newBook = _repository.Add(book);
            return CreatedAtAction(nameof(GetBook), new { id = newBook.Id }, newBook);
        }

        [HttpPut("id")]
        public IActionResult UpdateBook(int id, [FromBody] Book updateBook)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var success = _repository.Update(id, updateBook);
            if (!success) return NotFound();
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult DeleteBook(int id)
        {
            var success = _repository.Delete(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
