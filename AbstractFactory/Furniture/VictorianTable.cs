namespace AbstractFactory.Furniture;

public class VictorianTable : ITable
{
    public void Prepare()
    {
        Console.WriteLine("Preparing victorian table");
    }
}