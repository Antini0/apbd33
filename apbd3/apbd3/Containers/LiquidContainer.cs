namespace apbd3.Containers;

public class LiquidContainer : container
{
    private bool isHazardous;
    public LiquidContainer(double cargoMass, double height, double ownMass, double depth, double maxCargo, bool isHazardous) : base(cargoMass, height, ownMass, depth, maxCargo)
    {
        serialNum += "-L-" + Convert.ToString(contNum);
        this.isHazardous = isHazardous;
    }
    
    public override string ToString()
    {
        return $"Serial number: {serialNum}, Cargo mass: {cargoMass}, Height: {height}, Own mass: {ownMass}, Depth: {depth}, Max cargo: {maxCargo}";
    }
}