

using apbd3;
using apbd3.Containers;

//var container = new container(); 
int? a = 2;
a = null;

//map


var container = new LiquidContainer(20.0, 5.0, 2.0, 4.75, 40.0, true);
var container2 = new LiquidContainer(27.0, 4.0, 2.0, 4.75, 40.0, false);
var container3 = new GasContainer(27.0, 4.0, 2.0, 4.75, 40.0, 3);
var container4 = new CoolingContainer(12.0, 4.0, 2.0, 7.75, 35.0, PossibleProducts.FISH);
Console.WriteLine(container.ToString());
Console.WriteLine(container3.ToString());
Console.WriteLine(container4.ToString());

container2.Load(10);
container3.unload(20);

Console.WriteLine(container3.ToString());
Console.WriteLine("\n"+container2.ToString());