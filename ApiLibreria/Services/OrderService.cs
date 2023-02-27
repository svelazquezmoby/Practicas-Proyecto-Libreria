using DataBase;
using DataBase.Dtos.Order;
using Microsoft.IdentityModel.Logging;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService: IOrderService
    {
        private readonly IBookRepository _booksRepository;
        private readonly LogHelper _logHelper;

        public OrderService(IBookRepository booksRepository, LogHelper logHelper)
        {
            _booksRepository = booksRepository;
            _logHelper = logHelper;
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDTO GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDTO> GetOrderbyDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<OrderDTO> GetOrders()
        {
            throw new NotImplementedException();
        }

        public OrderDTO PostOrder(CreationOrderDTO creationOrderDTO)
        {
            throw new NotImplementedException();
        }

        public OrderDTO PutOrder(UpdateOrderDTO updateBookDTO)
        {
            throw new NotImplementedException();
        }
    }
}
