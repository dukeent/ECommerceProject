using ECommerceProject.Models;

namespace ECommerceProject.Interfaces.IServices
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAll();
        public Task<Product> GetById(int id);
        public Task<bool> PostUser(Product product);
        public Task<bool> DeleteUser(int id);
        public Task<bool> PutUser(int id, Product product);
        Task<IEnumerable<Product>> GetAll();

        Task<Product> GetById(int id);
        Task<bool> Add(Product entity);
        Task<bool> Delete(int id);
        Task<bool> Update(int id, Product entity);
    }
}
