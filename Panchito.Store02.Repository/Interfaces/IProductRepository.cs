using Panchito.Store02.Entity;

namespace Panchito.Store02.Repository.Interfaces
{
    public interface IProductRepository
    {

        Task<List<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
    }
}
