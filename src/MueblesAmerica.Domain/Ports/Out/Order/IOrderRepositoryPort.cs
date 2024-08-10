namespace MueblesAmerica.Domain.Ports.Out.Order
{
    public interface IOrderRepositoryPort
    {
        void AddOrder(Models.Order order);
        Models.Order GetOrderById(int id);
        List<Models.Order> GetAllOrders();
        void UpdateOrder(Models.Order order);
        void DeleteOrder(int id);
    }
}
