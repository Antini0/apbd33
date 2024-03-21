

using apbd3;
using apbd3.Containers;

//var container = new container(); 
int? a = 2;
a = null;

//map
Dictionary<PossibleProducts, double> products = new Dictionary<PossibleProducts, double>();

var container = new LiquidContainer(20.0, 5.0, 2.0, 4.75, 40.0, true);
var container2 = new LiquidContainer(27.0, 4.0, 2.0, 4.75, 40.0, false);
Console.WriteLine(container.ToString());
Console.WriteLine(container2.ToString());

container2.Load(10);
Console.WriteLine("\n"+container2.ToString());