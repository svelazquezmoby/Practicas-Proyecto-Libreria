using DataBase;
using DataBase.Dtos.Book;
using Microsoft.IdentityModel.Logging;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService: IBookService
    {
        private readonly IBookRepository _booksRepository;
        private readonly LogHelper _logHelper;

        public BookService(IBookRepository booksRepository, LogHelper logHelper)
        {
            _booksRepository = booksRepository;
            _logHelper = logHelper;
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public BookDTO GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookDTO> GetBookbyName(string name)
        {
            throw new NotImplementedException();
        }

        public List<BookDTO> GetBooks()
        {
            throw new NotImplementedException();
        }

        public BookDTO PostBook(CreationBookDTO creationBookDTO)
        {
            throw new NotImplementedException();
        }

        public BookDTO PutBook(UpdateBookDTO updateBookDTO)
        {
            throw new NotImplementedException();
        }
    }
}
