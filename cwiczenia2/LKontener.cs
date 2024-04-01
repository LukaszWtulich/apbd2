using System;
namespace cwiczenia2
{
    public class LKontener : Kontener, IHazardNotifier
    {
        public bool IsDangerous { get; private set; }

        public LKontener(string containerNumber, double loadCapacity, double weight, double height, double depth, bool isDangerous) : base(containerNumber, loadCapacity, weight, height, depth)
        {
            IsDangerous = isDangerous;
        }

        public override void Unload()
        {
            load_mass = 0;
        }

        public void notify(string containerNumber)
        {
            Console.WriteLine($"Dangerous situation in container {containerNumber}.");
        }

        public override ContainerType GetContainerType()
        {
            return ContainerType.Liquid;
        }
    }
}