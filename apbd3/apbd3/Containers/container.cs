namespace apbd3.Containers;

public abstract class container : Icontainer
{
        public double CargoMass { get; set; }
        public double height { get; set; }
        public double ownMass { get; set; }
        public double depth { get; set; }
        public string serialNum { get; set; }
        public double maxCargo { get; set; }
        private int contNum = 0;

        protected container(double cargoMass, double height, double ownMass, double depth, double maxCargo)
        {
                CargoMass = cargoMass;
                this.height = height;
                this.ownMass = ownMass;
                this.depth = depth;
                this.serialNum = "KON";
                this.maxCargo = maxCargo;
                contNum++;
        }

        public void unload()
        {
                throw new NotImplementedException();
        }

        public void Load(double cargoWeight)
        {
                throw new OverfillExcetion();
        }
        
        public string ToString()
        {
                return $"Serial number: {serialNum}, Cargo mass: {cargoMass}, Height: {height}, Own mass: {ownMass}, Depth: {depth}, Max cargo: {maxCargo}";
        }
}