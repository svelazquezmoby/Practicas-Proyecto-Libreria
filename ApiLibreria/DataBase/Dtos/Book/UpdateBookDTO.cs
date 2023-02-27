using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Dtos.Book
{
    public class UpdateBookDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} no debe tener mas de {1} caracteres")]
        public string Title { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} no debe tener mas de {1} caracteres")]
        public string Editorial { get; set; }
    }
}
