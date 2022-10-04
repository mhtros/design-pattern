using AbstractFactory.Furniture;

namespace AbstractFactory.Factories;

class ModernFurnitureFactoryFactory : IFurnitureFactory
{
    public ITable CreateTable()
    {
        return new ModernTable();
    }

    public IChair CreateChair()
    {
        return new ModernChair();
    }
}