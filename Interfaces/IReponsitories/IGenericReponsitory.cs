namespace ECommerceProject.Interfaces.IReponsitories
{
    public interface IGenericReponsitory<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);
        Task<bool> Add(T entity);
        Task<bool> Delete(int id);

    }
}
