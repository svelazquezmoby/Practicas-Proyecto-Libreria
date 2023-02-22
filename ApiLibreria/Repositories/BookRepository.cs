using AutoMapper;
using DataBase;
using DataBase.Dtos.Book;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BookDTO> GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookDTO>> GetBookbyName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Task<BookDTO> PostBook(CreationBookDTO creationBookDTO)
        {
            throw new NotImplementedException();
        }

        public Task<BookDTO> PutBook(UpdateBookDTO updateBookDTO)
        {
            throw new NotImplementedException();
        }
    }
}
