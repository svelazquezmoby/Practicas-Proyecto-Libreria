using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiAut.Validations;

namespace DataBase.Dtos.User
{
    public class CreationUserDTO
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} no debe tener mas de {1} caracteres")]
        [Mayuscula]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} no debe tener mas de {1} caracteres")]
        [Mayuscula]
        public string LastName { get; set; }
    }
}
