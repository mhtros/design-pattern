using AbstractFactory.Furniture;

namespace AbstractFactory.Factories;

public class VictorianFurnitureFactoryFactory : IFurnitureFactory
{
    public ITable CreateTable()
    {
        return new VictorianTable();
    }

    public IChair CreateChair()
    {
        return new VictorianChair();
    }
}