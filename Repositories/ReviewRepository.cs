using ECommerceProject.Interfaces.IRepositories;
using ECommerceProject.Models;

namespace ECommerceProject.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ECommerceProjectContext _dbContext) : base(_dbContext) { }
    }
}
