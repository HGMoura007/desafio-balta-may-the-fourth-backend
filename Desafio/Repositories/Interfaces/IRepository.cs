
public interface IRepository<T> where T : ModelBase
{
    Task<T> Create(T item);
    Task<T> FindByID(int id);
    Task<List<T>> FindAll();
    Task<T> Update(T item);
    Task Delete(int id);
    Task<bool> Exists(int id);
}

