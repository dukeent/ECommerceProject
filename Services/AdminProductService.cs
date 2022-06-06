using ECommerceProject.Interfaces.IConfiguration;
using ECommerceProject.Models;

namespace ECommerceProject.Services
{
    public class AdminProductService : IAdminProductService
    {
        IUnitOfWork unitOfWork;
        IAdminProductRepository adminProductRepository;

        public AdminProductService(IUnitOfWork _unitOfWork, IAdminProductRepository _adminProductRepository)
        {
            unitOfWork = _unitOfWork;
            adminProductRepository = _adminProductRepository;
        }
        public async Task<bool> DeleteProduct(int id)
        {
            try
            {
                if (unitOfWork.AdminProducts == null)
                {
                    throw new Exception("List Product is empty");
                }
                var product = await unitOfWork.AdminProducts.GetById(id);

                if (product == null)
                {
                    throw new Exception("Product not found");
                }
                await unitOfWork.AdminProducts.DeleteProduct(id);
                await unitOfWork.CompleteAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<Product>> GetAll()
        {

                return await unitOfWork.AdminProducts.GetAll();

        }

        public async Task<Product> GetById(int id)
        {
            try
            {
                if (unitOfWork.AdminProducts == null)
                {
                    throw new Exception("List Product is empty");
                }
                var product = await unitOfWork.AdminProducts.GetById(id);

                if (product == null)
                {
                    throw new Exception("Product not found");
                }

                return await unitOfWork.AdminProducts.GetById(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> PostProduct(Product product)
        {
            try
            {
                if (product != null)
                {
                    await unitOfWork.AdminProducts.PostProduct(product);
                    await unitOfWork.CompleteAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }

        public Task<bool> PutProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
