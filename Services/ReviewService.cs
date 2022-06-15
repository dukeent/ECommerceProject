using ECommerceProject.Interfaces.IConfiguration;
using ECommerceProject.Interfaces.IRepositories;
using ECommerceProject.Models;

namespace ECommerceProject.Services
{
    public class ReviewService
    {
        IUnitOfWork unitOfWork;
        IReviewRepository reviewRepository;

        public ReviewService(IUnitOfWork _unitOfWork, IReviewRepository _reviewRepository)
        {
            unitOfWork = _unitOfWork;
            reviewRepository = _reviewRepository;
        }
        public async Task<bool> Add(Review entity)
        {
            if (entity != null)
            {
                await unitOfWork.Reviews.Add(entity);
                await unitOfWork.CompleteAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            await unitOfWork.Reviews.Delete(id);
            await unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<IEnumerable<Review>> GetAll()
        {
            return await unitOfWork.Reviews.GetAll();
        }

        public async Task<Review> GetById(int id)
        {
            return await unitOfWork.Reviews.GetById(id);
        }

        public async Task<bool> Update(int id, Review entity)
        {
            unitOfWork.Reviews.Update(entity);
            await unitOfWork.CompleteAsync();
            return true;
        }
    }
}
