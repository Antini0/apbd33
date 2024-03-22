

using apbd3;
using apbd3.Containers;

void transferContainer(container c,ContainerShip originalShip, ContainerShip designatedShip)
{
    originalShip.removeContainer(c);
    designatedShip.addContainer(c);
}

void getContainerInfo(container c)
{
    Console.WriteLine(c.ToString());
}

void getShipInfo(ContainerShip cs)
{
    Console.WriteLine(cs.ToString());
}

List<container> list = new List<container>();

var container = new LiquidContainer(20.0, 5.0, 2.0, 4.75, 40.0, true);
var container2 = new LiquidContainer(27.0, 4.0, 2.0, 4.75, 40.0, false);
var container3 = new GasContainer(27.0, 4.0, 2.0, 4.75, 40.0, 3);
var container4 = new GasContainer(27.0, 4.0, 2.0, 4.75, 40.0, 3);
var container5 = new GasContainer(27.0, 4.0, 2.0, 4.75, 40.0, 3);
var container6 = new CoolingContainer(12.0, 4.0, 2.0, 7.75, 35.0, PossibleProducts.FISH);


list.Add(container2);
list.Add(container3);
list.Add(container4);
list.Add(container5);

var cs1 = new ContainerShip(30, 500, 20);

cs1.addContainer(container);

cs1.addMultipleContainers(list);

cs1.swapContainers(container6, "KON-G-3");

getShipInfo(cs1);

Console.WriteLine("FAFA");


