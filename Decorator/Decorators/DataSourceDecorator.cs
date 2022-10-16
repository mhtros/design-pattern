using Decorator.DataSource;

namespace Decorator.Decorators;

public class DataSourceDecorator : IDataSource
{
    private readonly IDataSource _wrapped;

    protected DataSourceDecorator(IDataSource wrapped)
    {
        _wrapped = wrapped;
    }

    public virtual async Task SaveDataAsync(string data)
    {
        await _wrapped.SaveDataAsync(data);
    }

    public virtual async Task<string> ReadDataAsync()
    {
        return await _wrapped.ReadDataAsync();
    }
}