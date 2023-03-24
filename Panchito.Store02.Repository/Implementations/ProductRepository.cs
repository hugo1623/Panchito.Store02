using Dapper;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using Panchito.Store02.Entity;
using Panchito.Store02.Repository.Interfaces;

namespace Panchito.Store02.Repository.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _configurationString;

        public ProductRepository(IConfiguration configuration )
        {
            _configurationString = configuration.GetConnectionString("OracleConnection");

        }
        public async Task<List<Product>> GetProductsAsync()
        {
            using (var connection = new OracleConnection(_configurationString))
            {
                var sql = "SELECT * FROM Product";
                var products = await connection.QueryAsync<Product>(sql);
                return products.ToList();
            }
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            using (var connection = new OracleConnection(_configurationString))
            {
                var sql = $"SELECT * FROM product WHERE id = {id}";
                var product = await connection.QueryFirstAsync<Product>(sql);
                return product;
            }
        }


    }
}
