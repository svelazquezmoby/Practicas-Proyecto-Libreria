﻿using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IUserRepository    
    {
        Task<List<User>> GetUsers();
        Task<UserDTO> GetUser(int id);
        Task<UserDTO> PostUser(CreationUserDTO creationUserDTO);
        Task DeleteUser(int id);
        Task<UserDTO> PutUser(PutUserDTO putUserDTO);
        Task<UserDTO> GetUserbyName(string name);
    }
}
