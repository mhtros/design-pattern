namespace AbstractFactory.Furniture;

public class ModernTable : ITable
{
    public void Prepare()
    {
        Console.WriteLine("Preparing modern table");
    }
}