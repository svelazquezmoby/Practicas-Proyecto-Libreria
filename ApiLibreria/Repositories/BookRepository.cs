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

        public async Task<List<BookDTO>> GetBooks()
        {
            var books = await _apilibreriaContext.Books.ToListAsync();

            return _mapper.Map<List<BookDTO>>(books);
        }

        public async Task<BookDTO> PostBook(CreationBookDTO creationBookDTO)
        {
            var book = _mapper.Map<Book>(creationBookDTO);
            _apilibreriaContext.Books.Add(book);
            await _apilibreriaContext.SaveChangesAsync();
            return await GetBook(book.BookId);
        
        }

        public async Task<BookDTO> PutBook(UpdateBookDTO updateBookDTO)
        {
            var book = _mapper.Map<Book>(updateBookDTO);

            _apilibreriaContext.Entry(book).State = EntityState.Modified;

            try
            {
                await _apilibreriaContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExistsBook(updateBookDTO.BookId))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return await GetBook(book.BookId);
        }
        private bool ExistsBook(int id)
        {
            return _apilibreriaContext.Books.Any(x => x.BookId.Equals(id));
        }
    }
}
