using ECommerceProject.Models;
using ECommerceProject.Data;
using ECommerceProject.Interfaces.IRepositories;



namespace ECommerceProject.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceProjectContext DbContext) : base(DbContext)
        {
        }
    }
}
>>>>>>>>> Temporary merge branch 2
