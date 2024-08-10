using MueblesAmerica.Domain.Ports.Out.Order;

namespace MueblesAmerica.Domain.Ports.In.Order
{
    public class CreateOrderCommand
    {
        private readonly IOrderRepositoryPort _orderRepositoryPort;

        public CreateOrderCommand(IOrderRepositoryPort orderRepositoryPort)
        {
            _orderRepositoryPort = orderRepositoryPort;
        }

        public void Execute(Models.Order order)
        {
            _orderRepositoryPort.AddOrder(order);
        }
    }
}
