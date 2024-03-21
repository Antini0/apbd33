namespace apbd3.Containers;

public class CoolingContainer : container
{
    private Dictionary<PossibleProducts, double> productDictionary = new Dictionary<PossibleProducts, double>
    {
        { PossibleProducts.BANANAS, 13.5 },
        { PossibleProducts.CHOCOLATE, 18.0 },
        { PossibleProducts.FISH, -2.0 },
        { PossibleProducts.MEAT, -5.0 },
        { PossibleProducts.ICE_CREAM, -20.0 },
        { PossibleProducts.FROZEN_PIZZA, -15.0 },
        { PossibleProducts.CHEESE, 4.0 },
        { PossibleProducts.SAUSAGES, -3.0 },
        { PossibleProducts.BUTTER, 5.0 },
        { PossibleProducts.EGGS, 2.0 }
    };
    
    public PossibleProducts productType { get; set; }
    public double tempreture { get; set; }


    public CoolingContainer(double cargoMass, double height, double ownMass, double depth, double maxCargo, PossibleProducts productType) : base(cargoMass, height, ownMass, depth, maxCargo)
    {
        serialNum += "-C-" + Convert.ToString(contNum);
        this.productType = productType;
        tempreture = productDictionary[productType];
    }
    
    public override string ToString()
    {
        return $"Serial number: {serialNum}, Cargo mass: {cargoMass}, Height: {height}, Own mass: {ownMass}, Depth: {depth}, Max cargo: {maxCargo}, Product: {productType}, Temperature: {tempreture}";
    }
}