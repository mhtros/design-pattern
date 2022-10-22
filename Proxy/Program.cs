using Proxy;

var driver1 = new Driver(12);
var driver2 = new Driver(18);

var proxy1 = new CarProxy(driver1);
var proxy2 = new CarProxy(driver2);

Console.Write("Driver 1: ");
proxy1.Drive();

Console.Write("Driver 2: ");
proxy2.Drive();