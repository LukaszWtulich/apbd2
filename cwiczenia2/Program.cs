using System;

namespace cwiczenia2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pojazd p1 = new Pojazd();
            LKontener liquidContainer = new LKontener("KON-L-1", 1000, 500, 200, 150, true);
            GKontener gasContainer = new GKontener("KON-G-1", 2000, 800, 250, 200, 2.5);
            CKontener cKontener= new CKontener("KON-C-1", 1500, 600, 220, 180, "Bananas", 5);
            try
            {
                liquidContainer.Load(100);
            }
            catch (OverfillException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                gasContainer.Load(200);
            }
            catch (OverfillException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                cKontener.Load(1400000);
            }
            catch (OverfillException ex)
            {
                Console.WriteLine(ex.Message);
            }
            p1.add_container(liquidContainer);
            p1.add_container(gasContainer);
            p1.print_containers();
            p1.remove_container(liquidContainer);
            Console.WriteLine();
            p1.print_containers();
        }
    }
}