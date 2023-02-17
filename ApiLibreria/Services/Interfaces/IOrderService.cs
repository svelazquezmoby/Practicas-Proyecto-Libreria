using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IOrderService
    { 
        List<Order> GetOrders();
        void DeleteOrder(int id);
        OrderDTO GetOrder(int id);
        OrderDTO PutOrder(PutOrderDTO putOrderDTO);
        OrderDTO PostOrder(CreationOrderDTO creationOrderDTO);
        List<Order> GetOrderbyDate(DateTime date);
    }
}
