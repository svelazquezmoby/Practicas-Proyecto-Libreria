using DataBase;
using DataBase.Dtos.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IOrderService
    { 
        List<OrderDTO> GetOrders();
        void DeleteOrder(int id);
        OrderDTO GetOrder(int id);
        OrderDTO PutOrder(UpdateOrderDTO updateBookDTO);
        OrderDTO PostOrder(CreationOrderDTO creationOrderDTO);
        List<OrderDTO> GetOrderbyDate(DateTime date);
    }
}
