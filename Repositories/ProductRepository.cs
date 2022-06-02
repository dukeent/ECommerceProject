using ECommerceProject.Models;

namespace ECommerceProject.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceProjectContext DbContext) : base(DbContext)
        {
        }
    }
}
