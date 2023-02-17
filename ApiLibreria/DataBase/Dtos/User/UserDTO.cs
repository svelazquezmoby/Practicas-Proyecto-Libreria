using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Dtos.User
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int IdOrder { get; set; }

    }
}
