using System;
using System.Collections.Generic;

namespace cwiczenia2
{
    public class Pojazd
    {
        public List<Kontener> container_list;

        public Pojazd()
        {
            container_list = new List<Kontener>();
        }
        public void add_container(Kontener k1)
        {
            container_list.Add(k1);
        }
        public void add_container(List<Kontener> k1)
        {
            for (int i = 0; i < k1.Count; ++i)
            {
                container_list.Add(k1[i]);
            }
        }

        public void remove_container(Kontener k1)
        {
            container_list.Remove(k1);
        }

        public void print_containers()
        {
            for (int i = 0; i < container_list.Count; ++i)
            {
                Console.WriteLine($"Typ:{container_list[i].GetContainerType()},Numer:{container_list[i].serial},Waga{container_list[i].load_mass}:");
            }
        }
    }
    
    
}