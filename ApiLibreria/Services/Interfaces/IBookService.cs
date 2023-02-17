using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBookService
    {      
            List<Book> GetBooks();
            void DeleteBook(int id);
            BookDTO GetBook(int id);
            BookDTO PutBook(PutBookDTO putBookDTO);
            BookDTO PostBook(CreationBookDTO creationBookDTO);
            List<BookDTO> GetBookbyName(string name);
        
    }
}
