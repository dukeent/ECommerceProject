using ECommerceProject.Interfaces.IConfiguration;
using ECommerceProject.Interfaces.IRepositories;

namespace ECommerceProject.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ECommerceProjectContext dbContext;
        public IProductRepository Products { get; private set; }
        public IUserRepository Users { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IOrderDetailRepository OrderDetails { get; private set; }
        public IReviewRepository Reviews { get; private set; }
        public IAdminProductRepository AdminProducts { get; private set; }

        public UnitOfWork(ECommerceProjectContext _dbContext)
        {
            dbContext = _dbContext;
            Users = new UserRepository(dbContext);
            AdminProducts = new AdminProductRepository(dbContext);
            Products = new ProductRepository(dbContext);
        }

        public async Task CompleteAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            dbContext.DisposeAsync();
        }
    }
}
