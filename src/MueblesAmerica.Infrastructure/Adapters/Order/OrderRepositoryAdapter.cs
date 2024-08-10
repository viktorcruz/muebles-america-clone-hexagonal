using MueblesAmerica.Domain.Ports.Out.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MueblesAmerica.Infrastructure.Adapters.Order
{
    public class OrderRepositoryAdapter : IOrderRepositoryPort
    {
        public OrderRepositoryAdapter()
        {
            
        }
        public void AddOrder(Domain.Models.Order order)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Models.Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Domain.Models.Order order)
        {
            throw new NotImplementedException();
        }
    }
}
