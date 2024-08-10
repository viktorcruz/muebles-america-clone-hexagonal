using MueblesAmerica.Domain.Ports.Out.OrderItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MueblesAmerica.Infrastructure.Adapters.OrderItem
{
    public class OrderItemRepositoryAdapter : IOrderItemRepositoryPort
    {
        public OrderItemRepositoryAdapter()
        {
            
        }
        public void AddOrderItem(Domain.Models.OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Models.OrderItem> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Domain.Models.OrderItem GetOrderItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderItem(Domain.Models.OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
