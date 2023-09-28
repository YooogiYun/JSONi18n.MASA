namespace JSONi18n.MASA.Shared.IServices;

/// <summary>
/// An interface for database CRUD.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IDatabaseService<T>
{
    public Task<List<T>> GetItemsAsync( );
    public Task<T> GetItemAsync(int id);
    public Task<T> GetItemAsync(string str);
    public Task<int> SaveItemAsync(T item);
    public Task<int> InsertItemAsync(T item);
    public Task<int> UpdateItemAsync(T item);
    public Task<int> DeleteItemAsync(T item);
}
