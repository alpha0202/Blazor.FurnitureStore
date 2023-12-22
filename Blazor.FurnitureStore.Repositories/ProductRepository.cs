using Blazor.FurnitureStore.Shared;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.FurnitureStore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }


        public async Task<IEnumerable<Product>> GetByCategory(int productCategoryId)
        {
            var sql = @"SELECT Id, Name, Price, CategoryId FROM Products WHERE CategoryId = @Id";


            return await _dbConnection.QueryAsync<Product>(sql, new {Id = productCategoryId });
        }
    }
}
