using AutoMapper;
using DataBase;
using DataBase.Dtos.Book;
using DataBase.Dtos.Order;
using DataBase.Dtos.User;

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

            CreateMap<CreationOrderDTO, Order>();
            CreateMap<UpdateOrderDTO, Order>();
            CreateMap<OrderDTO, Order>();
            CreateMap<Order, OrderDTO>();

            CreateMap<CreationUserDTO, User>();
            CreateMap<UpdateUserDTO, User>();
            CreateMap<UserDTO, Book>();
            CreateMap<User, UserDTO>();
        }
    }
}
