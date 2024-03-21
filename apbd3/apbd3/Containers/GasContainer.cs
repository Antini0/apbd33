namespace apbd3.Containers;

public class GasContainer : container, IHazardNotifier
{
    private double pressure;
    public GasContainer(double cargoMass, double height, double ownMass, double depth, double maxCargo, double pressure) : base(cargoMass, height, ownMass, depth, maxCargo)
    {
        serialNum += "-G-" + Convert.ToString(contNum);
        this.pressure = pressure;
    }

    public void notify()
    {
        Console.WriteLine("Uwaga po rozładowaniu w kontenerze " + serialNum + "  poniżej 5% ładnuku. Niebezpieczeństwo");
    }
    
    public void unload(double toUnload)
    {
        if (toUnload > cargoMass)
        {
            throw new takeTooMuchException("You want to unload more than the container has");
        }
        
        if (cargoMass - toUnload < cargoMass * 0.05)
        {
            notify();
        }
        cargoMass -= toUnload;
    }

    public void Load(double cargoWeight)
    {
        if (cargoMass + cargoWeight > maxCargo)
        {
            throw new OverfillExcetion("za duza masa ladunku");
        }
        this.cargoMass += cargoWeight;
    }
    
    public override string ToString()
    {
        return $"Serial number: {serialNum}, Cargo mass: {cargoMass}, Height: {height}, Own mass: {ownMass}, Depth: {depth}, Max cargo: {maxCargo}, Pressure: {pressure}";
    }
}