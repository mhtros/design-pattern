namespace AbstractFactory.Furniture;

internal class ModernChair : IChair
{
    public void sitOn()
    {
        Console.WriteLine("Siting on modern chair");
    }
}