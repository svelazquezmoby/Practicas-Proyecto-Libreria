using DataBase;
using DataBase.Dtos.User;
using Microsoft.IdentityModel.Logging;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService: IUserRepository
    {
        private readonly IBookRepository _booksRepository;
        private readonly LogHelper _logHelper;

        public UserService(IBookRepository booksRepository, LogHelper logHelper)
        {
            _booksRepository = booksRepository;
            _logHelper = logHelper;
        }

        public Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetUserbyName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> PostUser(CreationUserDTO creationUserDTO)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> PutUser(UpdateUserDTO updateUserDTO)
        {
            throw new NotImplementedException();
        }
    }
}
