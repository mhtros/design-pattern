namespace Decorator.DataSource;

public class FileDataSource : IDataSource
{
    private readonly string _filePath;

    public FileDataSource(string filePath)
    {
        _filePath = filePath;
    }

    public async Task SaveDataAsync(string data)
    {
        await File.WriteAllTextAsync(_filePath, data);
    }

    public async Task<string> ReadDataAsync()
    {
        return await File.ReadAllTextAsync(_filePath);
    }
}