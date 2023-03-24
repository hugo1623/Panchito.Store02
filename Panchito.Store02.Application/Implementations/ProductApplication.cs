using AutoMapper;
using Panchito.Store02.Application.Dtos;
using Panchito.Store02.Application.Interfaces;
using Panchito.Store02.Repository.Interfaces;

namespace Panchito.Store02.Application.Implementations
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductApplication(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var products = await productRepository.GetProductsAsync();
            var productsDto = mapper.Map<List<ProductDto>>(products);
            return productsDto;
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await productRepository.GetProductByIdAsync(id);
            var productDto = mapper.Map<ProductDto>(product);
            return productDto;
        }


    }
}
