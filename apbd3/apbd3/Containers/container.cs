namespace apbd3.Containers;

public abstract class container : Icontainer
{
        public double cargoMass { get; set; }
        public double height { get; set; }
        public double ownMass { get; set; }
        public double depth { get; set; }
        public string serialNum { get; set; }
        public double maxCargo { get; set; }
        public static int contNum = 0;

        public container(double cargoMass, double height, double ownMass, double depth, double maxCargo)
        {
                if (cargoMass > maxCargo)
                {
                        throw new OverfillExcetion("za duza masa ladunku");
                }
                this.cargoMass = cargoMass;
                this.height = height;
                this.ownMass = ownMass;
                this.depth = depth;
                serialNum = "KON";
                this.maxCargo = maxCargo;
                contNum++;
        }

        public void unload()
        {
                throw new NotImplementedException();
        }

        public void Load(double cargoWeight)
        {
                if (cargoMass + cargoWeight > maxCargo)
                {
                        throw new OverfillExcetion("za duza masa ladunku");
                }
                this.cargoMass += cargoWeight;
        }
        
        public virtual string ToString()
        {
                return $"Serial number: {serialNum}, Cargo mass: {cargoMass}, Height: {height}, Own mass: {ownMass}, Depth: {depth}, Max cargo: {maxCargo}";
        }
        
}