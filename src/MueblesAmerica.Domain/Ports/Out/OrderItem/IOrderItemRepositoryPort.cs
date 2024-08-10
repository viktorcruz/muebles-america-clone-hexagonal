namespace MueblesAmerica.Domain.Ports.Out.OrderItem
{
    public interface IOrderItemRepositoryPort
    {
        void AddOrderItem(Models.OrderItem orderItem);
        Models.OrderItem GetOrderItemById(int id);
        List<Models.OrderItem> GetAllOrders();
        void UpdateOrderItem(Models.OrderItem orderItem);
        void DeleteOrderItem(int id);
    }
}
