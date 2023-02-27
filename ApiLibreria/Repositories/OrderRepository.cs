using AutoMapper;
using DataBase;
using DataBase.Dtos.Order;
using Repositories.Interfaces;


namespace Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly ApilibreriaContext _apilibreriaContext;
        private readonly IMapper _mapper;

        public OrderRepository(ApilibreriaContext apilibreriaContext, IMapper mapper)
        {
            _apilibreriaContext = apilibreriaContext;
            _mapper = mapper;
        }

        public Task DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDTO> GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDTO>> GetOrderbyDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDTO>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDTO> PostOrder(CreationOrderDTO creationOrderDTO)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDTO> PutOrder(UpdateBookDTO updateBookDTO)
        {
            throw new NotImplementedException();
        }
    }
}
