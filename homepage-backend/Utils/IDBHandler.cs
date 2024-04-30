namespace homepage_backend.Utils;

public interface IDbHandler
{
    Task<T?> GetAsync<T>(string command, object param);
    Task<bool> ExecuteAsync(string command, object param);
}