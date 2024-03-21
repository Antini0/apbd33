namespace apbd3.Containers;

public class LiquidContainer : container, IHazardNotifier
{
    private bool isHazardous;
    public LiquidContainer(double cargoMass, double height, double ownMass, double depth, double maxCargo, bool isHazardous) : base(cargoMass, height, ownMass, depth, maxCargo)
    {
        serialNum += "-L-" + Convert.ToString(contNum);
        this.isHazardous = isHazardous;
    }

    public void notify()
    {
        if (isHazardous)
        {
            if (cargoMass > maxCargo / 2)
            {
                Console.WriteLine("\nMateriał niebezpieczny w kontenerze " + serialNum + " przekracza dozwolone 50% pojemności kontenera. Niebezpieczeństwo");
            }
        }
        else
        {
            if (cargoMass > maxCargo * 0.9)
            {
                Console.WriteLine("\nMateriał w kontenerze " + serialNum + " przekracza dozwolone 90% pojemności kontenera. Niebezpieczeństwo");
            }
        }
    }
    
    public void unload(double toUnload)
    {
        if (toUnload > cargoMass)
        {
            throw new takeTooMuchException("You want to unload more than the container has");
        }
        this.cargoMass -= toUnload;
    }

    public void Load(double cargoWeight)
    {
        if (cargoMass + cargoWeight > maxCargo)
        {
            throw new OverfillExcetion("za duza masa ladunku");
        }
        this.cargoMass += cargoWeight;
        notify();
    }
    
    public override string ToString()
    {
        if (!isHazardous)
        {
            return $"Serial number: {serialNum}, Cargo mass: {cargoMass}, Height: {height}, Own mass: {ownMass}, Depth: {depth}, Max cargo: {maxCargo}";
        }
        else
        {
            return $"Serial number: {serialNum}, Cargo mass: {cargoMass}, Height: {height}, Own mass: {ownMass}, Depth: {depth}, Max cargo: {maxCargo}, Materiał Niebezpieczny";
        }
    }
}