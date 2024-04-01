using System;
namespace cwiczenia2
{
    public class GKontener : Kontener, IHazardNotifier
    {
        public double Pressure { get; private set; }

        public GKontener(string containerNumber, double loadCapacity, double weight, double height, double depth, double pressure) : base(containerNumber, loadCapacity, weight, height, depth)
        {
            Pressure = pressure;
        }

        public override void Unload()
        {
            load_mass = max_load * 0.05; 
        }

        public void notify(string containerNumber)
        {
            Console.WriteLine($"Dangerous situation in container {containerNumber}.");
        }

        public override ContainerType GetContainerType()
        {
            return ContainerType.Gas;
        }
    }
}