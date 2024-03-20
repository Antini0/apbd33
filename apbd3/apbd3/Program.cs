

using apbd3;
using apbd3.Containers;

//var container = new container(); 
int? a = 2;
a = null;

//map
Dictionary<PossibleProducts, double> products = new Dictionary<PossibleProducts, double>();

var container = new LiquidContainer(30.0, 5.0, 2.0, 4.75, 40.0);
Console.WriteLine(container);