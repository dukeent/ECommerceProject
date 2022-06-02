using ECommerceProject.Models;

namespace ECommerceProject.Interfaces.IServices
{
    public interface IAdminProductService
    {
        public Task<IEnumerable<Product>> GetAll();
        public Task<Product> GetById(int id);
        public Task<bool> PostProduct(Product product);
        public Task<bool> DeleteProduct(int id);
        public Task<bool> PutProduct(int id, Product product);
    }
}
