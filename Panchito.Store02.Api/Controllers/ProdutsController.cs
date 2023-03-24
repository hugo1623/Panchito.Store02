using Microsoft.AspNetCore.Mvc;
using Panchito.Store02.Application.Dtos;
using Panchito.Store02.Application.Interfaces;

namespace Panchito.Store02.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutsController : ControllerBase
    {
        private readonly IProductApplication productApplication;

        public ProdutsController( IProductApplication productApplication)
        {
            this.productApplication = productApplication;
        }
        [HttpGet]

        public async Task<ActionResult<List<ProductDto>>> GetProducts()
        {
            var products = await productApplication.GetProductsAsync();
            return products;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var product = await productApplication.GetProductByIdAsync(id);
            return product;
        }
    }
}
