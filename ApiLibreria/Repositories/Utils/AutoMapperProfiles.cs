using AutoMapper;
using DataBase;
using DataBase.Dtos.Book;

namespace Repositories.Utils
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CreationBookDTO, Book>();
            CreateMap<UpdateBookDTO, Book>();
            CreateMap<BookDTO, Book>();
            CreateMap<Book, BookDTO>();
        }
    }
}
