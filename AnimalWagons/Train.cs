using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWagons
{
    class Train
    {
        List<Wagon> wagons = new List<Wagon>();
        List<Wagon> fullwagons = new List<Wagon>();
        
       public void VoegToe(string dier,Animal a)
        {
            bool added = false;
            if (wagons.Count == 0)
            {
                Wagon newWagon = new Wagon();
                wagons.Add(newWagon);


            }
            foreach (Wagon w in wagons)
            {
                if (w.VoegToe (dier, a))
                {
                    if (w.isVol())
                    {
                        fullwagons.Add(w);
                        Console.WriteLine("wagon is full");
                        wagons.Remove(w);
                        return;
                    }
                    added = true;
                }
            }
            if (!added)
            {
                Wagon newWagon = new Wagon();
                wagons.Add(newWagon);
                Console.WriteLine("new wagon added");
                VoegToe(dier, a);
            }
            Console.WriteLine($"er zijn nu {wagons.Count}");

        }

    }
}
