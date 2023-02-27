using AutoMapper;
using DataBase;
using DataBase.Dtos.Order;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System.Net;
using Utils.Exceptions;

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

        public async Task DeleteOrder(int id)
        {
            var order = await _apilibreriaContext.Orders.FindAsync(id);

            if (order == null)
            {
                throw new HttpException("No se encontró la computadora.", HttpStatusCode.NotFound);
            }

            _apilibreriaContext.Orders.Remove(order);
            await _apilibreriaContext.SaveChangesAsync();
        }

        public async Task<OrderDTO> GetOrder(int id)
        {
            var order = await _apilibreriaContext.Orders.FirstOrDefaultAsync(x => x.OrderId == id);

            if (order == null)
            {
                throw new HttpException("No se encontró el usuario.", HttpStatusCode.NotFound);
            }

            return _mapper.Map<OrderDTO>(order);
        }

        public Task<List<OrderDTO>> GetOrderbyDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDTO>> GetOrders()
        {
            var orders = await _apilibreriaContext.Books.ToListAsync();
            return _mapper.Map<List<OrderDTO>>(orders);
        }

        public async Task<OrderDTO> PostOrder(CreationOrderDTO creationOrderDTO)
        {
            var order = _mapper.Map<Order>(creationOrderDTO);
            _apilibreriaContext.Orders.Add(order);
            await _apilibreriaContext.SaveChangesAsync();
            return await GetOrder(order.OrderId);

        }

        public async Task<OrderDTO> PutOrder(UpdateOrderDTO updateOrderDTO)
        {
            var order = _mapper.Map<Order>(updateOrderDTO);

            _apilibreriaContext.Entry(order).State = EntityState.Modified;

            try
            {
                await _apilibreriaContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExistsUser(updateOrderDTO.OrderId))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return await GetOrder(order.OrderId);
        }
        private bool ExistsUser(int id)
        {
            return _apilibreriaContext.Orders.Any(x => x.OrderId.Equals(id));
        }
    
    }
}
