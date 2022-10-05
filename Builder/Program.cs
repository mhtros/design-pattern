using Builder.Builder;
using Builder.Director;

CarBuilder carBuilder = new();
CarDirector carDirector = new(carBuilder);

// Create a complex car class using the help of CarDirector
var defaultCar = carDirector.CreateDefault();

// Or you can manually create it using the CarBuilder directly
var sportCar = carBuilder
    .Reset() // rest builder to clear the old values
    .SetWheels(4)
    .SetDoors(2)
    .SetSeats(2)
    .SetColor("Blue Electric")
    .SetEngineType("V12")
    .SetAerofoil(true)
    .SetNitro(true)
    .Instantiate();

Console.WriteLine(defaultCar);
Console.WriteLine(sportCar);