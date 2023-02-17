using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Dtos.Order
{
    public class OrderDTO
    {
        public int IdOrder { get; set; }
        public string Detail { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
    }
}
