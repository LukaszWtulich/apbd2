using System;
namespace cwiczenia2
{
    public abstract class Kontener
    {
        public double load_mass { get; set; }
        public double height{ get; set; }
        public double container_mass{ get; set; }
        public double depth{ get; set; }
        public string serial{ get; set; }
        public double max_load{ get; set; }
        public void Load(double cargoWeight)
        {
            if (cargoWeight > max_load)
            {
                throw new OverfillException("Cargo weight exceeds container capacity.");
            }
            load_mass = cargoWeight;
        }

        public abstract void Unload();

        public abstract ContainerType GetContainerType();
        public Kontener(string containerNumber, double loadCapacity, double weight, double height, double depth)
        {
            serial = containerNumber;
            max_load= loadCapacity;
            load_mass = weight;
            this.height = height;
            this.depth = depth;
        }
    }
   
}