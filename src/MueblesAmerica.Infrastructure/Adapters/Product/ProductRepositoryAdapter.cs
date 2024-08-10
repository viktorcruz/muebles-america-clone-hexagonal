using MueblesAmerica.Domain.Ports.Out.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MueblesAmerica.Infrastructure.Adapters.Product
{
    public class ProductRepositoryAdapter : IProductRepositoryPort
    {
        public ProductRepositoryAdapter()
        {
            
        }
        public void AddProduct(Domain.Models.Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Models.Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Domain.Models.Product product)
        {
            throw new NotImplementedException();
        }
    }
}
