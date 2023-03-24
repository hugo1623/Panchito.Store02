using Panchito.Store02.Entity;
using Panchito.Store02.Repository.Interfaces;

namespace Panchito.Store02.Repository.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
