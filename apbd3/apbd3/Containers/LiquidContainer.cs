namespace apbd3.Containers;

public class LiquidContainer : container
{
    public LiquidContainer(double cargoMass, double height, double ownMass, double depth, string serialNum, double maxCargo, int contNum) : base(cargoMass, height, ownMass, depth, serialNum, maxCargo)
    {
        serialNum += "-L-" + serialNum.ToString();
    }
    
    public override string ToString()
    {
        return $"Serial number: {serialNum}, Cargo mass: {cargoMass}, Height: {height}, Own mass: {ownMass}, Depth: {depth}, Max cargo: {maxCargo}";
    }
}