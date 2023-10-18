using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.PublicModel;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderBus _orderBus;
        public OrderController (IOrderBus orderBus)
        {
            _orderBus = orderBus;
        }
        [HttpPost]
        [Route("CreateOrder")]
        public IActionResult CreateOrder(OrderModel Order)
        {
            return Ok(_orderBus.CreateOrder(Order)); 
        }
    }
}
