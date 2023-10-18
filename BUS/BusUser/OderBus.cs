using BLL.Iterfaces;
using DAL.Iterfaces;
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusUser
{
    public class OderBus : IOrderBus
    {
        private IOrderRepository _orderRepository;
        public OderBus (IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public bool CreateOrder(OrderModel Order)
        {
            return _orderRepository.CreateOrder(Order);
        }
    }
}
