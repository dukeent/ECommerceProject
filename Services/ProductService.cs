using ECommerceProject.Interfaces.IConfiguration;
using ECommerceProject.Interfaces.IRepositories;
using ECommerceProject.Interfaces.IServices;
using ECommerceProject.Models;

namespace ECommerceProject.Services
{
    public class ProductService : IProductService
    {
        IUnitOfWork unitOfWork;
        IProductRepository productRepository;

        public ProductService(IUnitOfWork _unitOfWork, IProductRepository _productRepository)
        {
            unitOfWork = _unitOfWork;
            productRepository = _productRepository;
        }
        public async Task<bool> Add(Product entity)
        {
            if (entity != null)
            {
                await unitOfWork.Products.Add(entity);
                await unitOfWork.CompleteAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            await unitOfWork.Products.Delete(id);
            await unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await unitOfWork.Products.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await unitOfWork.Products.GetById(id);
        }

        public async Task<bool> Update(int id, Product entity)
        {
            unitOfWork.Products.Update(entity);
            await unitOfWork.CompleteAsync();
            return true;
        }
    }
}