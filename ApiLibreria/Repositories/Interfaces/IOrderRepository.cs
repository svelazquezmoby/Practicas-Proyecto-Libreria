using DataBase;
using DataBase.Dtos.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<OrderDTO>> GetOrders();
        Task<OrderDTO> GetOrder(int id);
        Task<OrderDTO> PostOrder(CreationOrderDTO creationOrderDTO);
        Task DeleteOrder(int id);
        Task<OrderDTO> PutOrder(UpdateBookDTO updateBookDTO);
        Task<List<OrderDTO>> GetOrderbyDate(DateTime date);
    }
}
