using DataBase;
using DataBase.Dtos.User;

namespace Repositories.Interfaces
{
    public interface IUserRepository    
    {
        Task<List<UserDTO>> GetUsers();
        Task<UserDTO> GetUser(int id);
        Task<UserDTO> PostUser(CreationUserDTO creationUserDTO);
        Task DeleteUser(int id);
        Task<UserDTO> PutUser(UpdateUserDTO updateUserDTO);
        Task<UserDTO> GetUserbyName(string name);
    }
}
