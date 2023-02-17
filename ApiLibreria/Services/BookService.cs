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
        private readonly IBooksRepository _booksRepository;
        private readonly ILogHelper _logHelper;

        public BookService(IBooksRepository booksRepository, ILogHelper logHelper)
        {
            _booksRepository = booksRepository;
            _logHelper = logHelper;
        }
    }
}
