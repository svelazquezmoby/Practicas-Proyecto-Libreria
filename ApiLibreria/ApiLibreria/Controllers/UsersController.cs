using DataBase.Dtos.User;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace ApiLibreria.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// Mostrar listado de usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<UserDTO> Get()
        {
            return _userService.GetUsers();
        }

        /// <summary>
        /// Mostrar usuario por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public UserDTO Get(int id)
        {
            return _userService.GetUser(id);
        }
        /// <summary>
        /// Crear usuario
        /// </summary>
        /// <param name="creationUserDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public UserDTO Post(CreationUserDTO creationUserDTO)
        {
            return _userService.PostUser(creationUserDTO);
        }

        /// <summary>
        ///  Actualizar un usuario
        /// </summary>
        /// <param name="putUserDTO"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public UserDTO PutUser(UpdateUserDTO updateUserDTO)
        {
            return _userService.PutUser(updateUserDTO);
        }
        /// <summary>
        /// Eliminar un usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            _userService.DeleteUser(id);
            return Ok("El usuario se eliminó con éxito.");
        }/// <summary>
         /// Buscar usuario por nombre
         /// </summary>
         /// <param name="name"></param>
         /// <returns></returns>
        [HttpGet("name")]
        public List<UserDTO> GetUserbyName([FromQuery] string name)
        {
            return _userService.GetUserbyName(name);
        }
    }
}

