namespace apbd3.Containers;

public abstract class container : Icontainer
{
        public double CargoMass { get; set; }
        public double height { get; set; }
        public double ownMass { get; set; }
        public double depth { get; set; }
        public string serialNum { get; set; }
        public double maxCargo { get; set; }

        protected container(double cargoMass, double height, double ownMass, double depth, string serialNum, double maxCargo)
        {
                CargoMass = cargoMass;
                this.height = height;
                this.ownMass = ownMass;
                this.depth = depth;
                this.serialNum = serialNum;
                this.maxCargo = maxCargo;
        }

        public void unload()
        {
                throw new NotImplementedException();
        }

        public void Load(double cargoWeight)
        {
                throw new OverfillExcetion();
        }
}