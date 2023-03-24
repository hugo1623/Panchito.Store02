using Panchito.Store02.Application.Dtos;

namespace Panchito.Store02.Application.Interfaces
{
    public interface IProductApplication
    {
        Task<List<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
    }
}
