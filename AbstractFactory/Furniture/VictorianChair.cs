namespace AbstractFactory.Furniture;

public class VictorianChair : IChair
{
    public void sitOn()
    {
        Console.WriteLine("Siting on victorian chair");
    }
}