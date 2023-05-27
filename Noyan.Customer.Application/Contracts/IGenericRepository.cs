namespace Noyan.Customers.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<T> Add(T tEntity);
        Task<T> Update(T tEntity);
        Task Delete(T tEntity);
        Task<IReadOnlyList<T>> GetAll();  
    }
}
