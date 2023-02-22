using AutoMapper;
using DataBase;
using DataBase.Dtos.User;
using Repositories.Interfaces;

namespace Repositories
{    public class UserRepository : IUserRepository
     {
            private readonly ApilibreriaContext _apilibreriaContext;
            private readonly IMapper _mapper;

        public UserRepository(ApilibreriaContext apilibreriaContext, IMapper mapper)
        {
            _apilibreriaContext = apilibreriaContext;
            _mapper = mapper;
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
