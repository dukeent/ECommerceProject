using ECommerceProject.Data;
using ECommerceProject.Interfaces.IReponsitories;
using ECommerceProject.Models;

namespace ECommerceProject.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceProjectContext _dbContext) : base(_dbContext)
        {
        }
    }
}
