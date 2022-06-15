using ECommerceProject.Models;

namespace ECommerceProject.Interfaces.IServices
{
    public interface IReviewService
    {
        Task<IEnumerable<Review>> GetAll();

        Task<Review> GetById(int id);
        Task<bool> Add(Review entity);
        Task<bool> Delete(int id);
        Task<bool> Update(int id, Review entity);
    }
}
