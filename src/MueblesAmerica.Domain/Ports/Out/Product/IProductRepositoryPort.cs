namespace MueblesAmerica.Domain.Ports.Out.Product
{
    public interface IProductRepositoryPort
    {
        void AddProduct(Models.Product product);
        Models.Product GetProductById(int id);
        List<Models.Product> GetAllProducts();
        void UpdateProduct(Models.Product product);
        void DeleteProduct(int id);
    }
}
