using DataBase;
using DataBase.Dtos.Book;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace ApiLibreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/Computers
        [HttpGet]
        public List<BookDTO> GetComputers()
        {
            return _bookService.GetBooks();
        }

        // GET: api/Computers/5
        [HttpGet("{id}")]
        public BookDTO GetComputer(int id)
        {
            return _bookService.GetBook(id);
        }

        // PUT: api/Computers/5
        [HttpPut("{id}")]
        public BookDTO PutComputer(UpdateBookDTO updateBookDTO)
        {
            return _bookService.PutBook(updateBookDTO);
        }

        // POST: api/Computers
        [HttpPost]
        public BookDTO PostComputer(CreationBookDTO creationBookDTO)
        {
            return _bookService.PostBook(creationBookDTO);
        }

        // DELETE: api/Computers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return Ok("La computadora se eliminó con éxito.");
        }
    }
}
