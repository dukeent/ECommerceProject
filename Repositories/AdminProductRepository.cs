using ECommerceProject.Interfaces.IReponsitories;
using ECommerceProject.Models;

namespace ECommerceProject.Repositories
{
    public class AdminProductRepository : GenericRepository<Product>, IAdminProductRepository
    {
        public AdminProductRepository(ECommerceProjectContext _dbContext) : base(_dbContext)
        {
        }

        Task<bool> IAdminProductRepository.DeleteProduct(int id)
        {
            return base.Delete(id);
        }

        Task<IEnumerable<Product>> IAdminProductRepository.GetAll()
        {
            return base.GetAll();
        }

        Task<Product> IAdminProductRepository.GetById(int id)
        {
            return base.GetById(id);
        }

        Task<bool> IAdminProductRepository.PostProduct(Product product)
        {
            return base.Add(product);
        }

        Task<bool> IAdminProductRepository.PutProduct(int id, Product product)
        {
            return base.UpdateByID(id, product);
        }
    }
}
