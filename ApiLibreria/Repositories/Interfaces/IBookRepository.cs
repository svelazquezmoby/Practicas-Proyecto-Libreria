using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetBooks();
        Task<BookDTO> GetBook(int id);
        Task<BookDTO> PostBook(CreationBookDTO creationBookDTO);
        Task DeleteBook(int id);
        Task<BookDTO> PutBook(PutBookDTO putBookDTO);
        Task<List<BookDTO>> GetBookbyName(string name);
    }
}
