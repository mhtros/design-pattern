namespace Singleton;

public class Database
{
    private static Database? _database;
    private static readonly object Padlock = new();

    private Database()
    {
    }

    public static Database CreateInstance()
    {
        lock (Padlock)
        {
            return _database ??= new Database();
        }
    }

    public static void ExecuteQuery(string query)
    {
        Console.WriteLine($"Executing query: {query}");
    }
}