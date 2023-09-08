using Blazor.FurnitureStore.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.FurnitureStore.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {

        private readonly IDbConnection _dbConnection;

        public ProductCategoryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Task<IEnumerable<ProductCategory>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
