namespace Decorator.DataSource;

public interface IDataSource
{
    public Task SaveDataAsync(string data);

    public Task<string> ReadDataAsync();
}