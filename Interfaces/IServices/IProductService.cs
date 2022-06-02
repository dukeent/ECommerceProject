using ECommerceProject.Models;

namespace ECommerceProject.Interfaces.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();

        Task<Product> GetById(int id);
        Task<bool> Add(Product entity);
        Task<bool> Delete(int id);
    }
}