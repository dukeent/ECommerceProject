using ECommerceProject.Models;
namespace ECommerceProject.Interfaces.IReponsitories
{
    public interface IAdminProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<bool> PostProduct(Product product);
        Task<bool> DeleteProduct(int id);
        Task<bool> PutProduct(int id, Product product);
    }
}
