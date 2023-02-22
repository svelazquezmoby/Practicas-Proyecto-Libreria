using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Dtos.Order
{
    public class CreationOrderDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} no debe tener mas de {1} caracteres")]
        [Mayuscula]
        public string Title { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} no debe tener mas de {1} caracteres")]
        [Mayuscula]
        public string Editorial { get; set; }
    }
}
