namespace ECommerceProject.Services
{
    public class ProductService
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
            var result = await unitOfWork.Products.GetById(id);
            return result;
        }
    }
}
