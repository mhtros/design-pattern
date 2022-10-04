using AbstractFactory.Factories;

var type = new Random().Next(0, 2); // between 0 and 1

IFurnitureFactory? factory = type switch
{
    (int) FurnitureFactoryType.Victorian => new VictorianFurnitureFactoryFactory(),
    (int) FurnitureFactoryType.Modern => new ModernFurnitureFactoryFactory(),
    _ => null
};

var chair = factory?.CreateChair();
var table = factory?.CreateTable();

chair?.sitOn();
table?.Prepare();