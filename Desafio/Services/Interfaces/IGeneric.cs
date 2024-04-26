
public interface IGeneric<T>
{
    Task<T> FindByID(int id);
    Task<List<T>> FindAll();
}

