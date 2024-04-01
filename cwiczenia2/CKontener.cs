using System;
namespace cwiczenia2
{
    public class CKontener : Kontener, IHazardNotifier
    {
        public string ProductType { get; private set; }
        public double Temperature { get; private set; }

        public CKontener (string containerNumber, double loadCapacity, double weight, double height, double depth, string productType, double temperature) : base(containerNumber, loadCapacity, weight, height, depth)
        {
            ProductType = productType;
            Temperature = temperature;
        }

        public override void Unload()
        {
            max_load = 0;
        }

        public void notify(string containerNumber)
        {
            Console.WriteLine($"Dangerous situation in container {containerNumber}.");
        }

        public override ContainerType GetContainerType()
        {
            return ContainerType.Refrigerated;
        }
    }

}