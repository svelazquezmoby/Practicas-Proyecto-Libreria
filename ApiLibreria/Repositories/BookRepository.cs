using AutoMapper;
using DataBase;
using DataBase.Dtos.Book;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System.Net;
using Utils.Exceptions;

namespace Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly ApilibreriaContext _apilibreriaContext;
        private readonly IMapper _mapper;

        public BookRepository(ApilibreriaContext apilibreriaContext, IMapper mapper)
        {
            _apilibreriaContext = apilibreriaContext;
            _mapper = mapper;
        }

        public async Task DeleteBook(int id)
        {
            var book = await _apilibreriaContext.Books.FindAsync(id);

            if (book == null)
            {
                throw new HttpException("No se encontró la computadora.", HttpStatusCode.NotFound);
            }

            _apilibreriaContext.Books.Remove(book);
            await _apilibreriaContext.SaveChangesAsync();
        }

        public async Task<BookDTO> GetBook(int id)
        {
            var book = await _apilibreriaContext.Books
                                                    .FirstOrDefaultAsync(x => x.BookId == id);

            if (book == null)
            {
                throw new HttpException("No se encontró la computadora.", HttpStatusCode.NotFound);
            }

            return _mapper.Map<BookDTO>(book);
        }

        public Task<List<BookDTO>> GetBookbyName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetBooks()
        {
            var books = await _apilibreriaContext.Books.ToListAsync();

            return _mapper.Map<List<Book>>(books);
        }

        public async Task<BookDTO> PostBook(CreationBookDTO creationBookDTO)
        {
            throw new NotImplementedException();


        }

        public async Task<BookDTO> PutBook(UpdateBookDTO updateBookDTO)
        {
            throw new NotImplementedException();

        }
    }
}
