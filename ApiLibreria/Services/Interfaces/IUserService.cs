using DataBase;
using DataBase.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetUsers();
        void DeleteUser(int id);
        UserDTO GetUser(int id);
        UserDTO PutUser(UpdateUserDTO updateUserDTO);
        UserDTO PostUser(CreationUserDTO creationUserDTO);
        List<UserDTO> GetUserbyName(string name);
    }
}
