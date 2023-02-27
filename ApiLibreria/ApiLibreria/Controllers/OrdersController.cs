using DataBase;
using DataBase.Dtos.Order;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace ApiLibreria.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        /// <summary>
        /// Mostrar listado de pedidos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<OrderDTO> Get()
        {
            return _orderService.GetOrders();
        }

        /// <summary>
        /// Mostrar pedido por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public OrderDTO Get(int id)
        {
            return _orderService.GetOrder(id);
        }
        /// <summary>
        /// Agregar pedido
        /// </summary>
        /// <param name="creationOrderDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public OrderDTO Post(CreationOrderDTO creationOrderDTO)
        {
            return _orderService.PostOrder(creationOrderDTO);
        }

        /// <summary>
        /// Actualizar pedido
        /// </summary>
        /// <param name="putOrderDTO"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public OrderDTO PutBook(UpdateBookDTO updateBookDTO)
        {
            return _orderService.PutOrder(updateBookDTO);

        }
        /// <summary>
        /// Eliminar un pedido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            _orderService.DeleteOrder(id);
            return Ok("El pedido se eliminó con éxito.");
        }
        /// <summary>
        /// Buscar por fecha de inicio
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpGet("{date}")]
        public List<OrderDTO> GetOrderbyDate(DateTime date)
        {
            return _orderService.GetOrderbyDate(date);
        }
    }
}

