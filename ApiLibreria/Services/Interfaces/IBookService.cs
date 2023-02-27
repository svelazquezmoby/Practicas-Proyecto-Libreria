using DataBase;
using DataBase.Dtos.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBookService
    {      
            List<BookDTO> GetBooks();
            void DeleteBook(int id);
            BookDTO GetBook(int id);
            BookDTO PutBook(UpdateBookDTO updateBookDTO);
            BookDTO PostBook(CreationBookDTO creationBookDTO);
            List<BookDTO> GetBookbyName(string name);
        
    }
}
