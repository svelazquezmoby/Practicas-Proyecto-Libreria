using AutoMapper;
using DataBase;
using DataBase.Dtos.User;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System.Net;
using Utils.Exceptions;

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

        public async Task DeleteUser(int id)
        {
            var user = await _apilibreriaContext.Users.FindAsync(id);

            if (user == null)
            {
                throw new HttpException("No se encontró el usuario.", HttpStatusCode.NotFound);
            }

            _apilibreriaContext.Users.Remove(user);
            await _apilibreriaContext.SaveChangesAsync();
        }

        public async Task<UserDTO> GetUser(int id)
        {
            var user = await _apilibreriaContext.Users.FirstOrDefaultAsync(x => x.UserId == id);

            if (user == null)
            {
                throw new HttpException("No se encontró el usuario.", HttpStatusCode.NotFound);
            }

            return _mapper.Map<UserDTO>(user);
        }

        public Task<UserDTO> GetUserbyName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            var users = await _apilibreriaContext.Users.ToListAsync();
            return _mapper.Map<List<UserDTO>>(users);
        }

        public async Task<UserDTO> PostUser(CreationUserDTO creationUserDTO)
        {
            var user = _mapper.Map<User>(creationUserDTO);
            _apilibreriaContext.Users.Add(user);
            await _apilibreriaContext.SaveChangesAsync();
            return await GetUser(user.UserId);

        }

        public async Task<UserDTO> PutUser(UpdateUserDTO updateUserDTO)
        {
            var user = _mapper.Map<User>(updateUserDTO);

            _apilibreriaContext.Entry(user).State = EntityState.Modified;

            try
            {
                await _apilibreriaContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExistsUser(updateUserDTO.UserId))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return await GetUser(user.UserId);
        }

        private bool ExistsUser(int id)
        {
            return _apilibreriaContext.Users.Any(x => x.UserId.Equals(id));
        }

    }

}
