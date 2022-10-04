using AbstractFactory.Furniture;

namespace AbstractFactory.Factories;

public interface IFurnitureFactory
{
    public ITable CreateTable();

    public IChair CreateChair();
}