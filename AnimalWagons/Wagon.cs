using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWagons
{
    
    class Wagon
    {
        const int MAX_CAPACITY = 10;
        private List<Animal> list = new List<Animal>();

        internal List<Animal> List { get => list; set => list = value; }

        int currSize ()
        {
            int total = 0;
            foreach(Animal a in List)
            {
                total = total + (int) a.Size;
            }
            return total;
        }
        // size check
        bool tryAddAnimal(Animal a)
        {
            if (currSize()+(int)a.Size > MAX_CAPACITY)
            {
                return false;
            } else
            {
                return true;
            }
        }

        Animal getLargestCarnivore ()
        {
            Animal largest = null;
            int largestsize = 5;
            foreach (Animal a in List)
            {
                if (a.Type == AnimalType.Carnivore)
                {
                    if ((int) a.Size >= largestsize)
                    {
                        largest = a;
                    }
                }
               
            }
            return largest;
        }

        Animal getSmallestHerbivore()
        {
            int smallestSize = 5;
            Animal smallest= null;
            foreach (Animal a in List)
            {
                if (a.Type == AnimalType.Herbivore)
                {
                    if ((int)a.Size <= smallestSize)
                    {
                        smallest = a;
                        smallestSize = (int)a.Size;
                    }

                }
            }
            return smallest;
        }

        public bool canIAdd(Animal a)
        {
            bool result = false;
            Animal largestCarnivore = getLargestCarnivore();
            Animal smallestHerbivore = getSmallestHerbivore();
            if (largestCarnivore != null)
            {
                if (a.Type == AnimalType.Herbivore && a.Size > largestCarnivore.Size)
                {
                    return true;
                } else
                {
                    return false;
                }

            } else
            {
               
                // 
                if (smallestHerbivore == null)
                {
                    return true;
                }
                if (tryAddAnimal(a))
                {
                    if (a.Type == AnimalType.Carnivore)
                    {
                        if (a.Size < smallestHerbivore.Size)
                        {
                            return true;
                        } else
                        {
                            return false;
                        }
                    } else
                    {
                        return true;
                    }

                } else
                {
                    return false;
                }
            }

            //return result;
        }

        public bool isVol()
        {
            Animal largestCarnivore = getLargestCarnivore();
            if (largestCarnivore == null)
            {
                if (currSize() == MAX_CAPACITY)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            else

            {

                if (getLargestCarnivore().Size == AnimalSize.large || currSize() == MAX_CAPACITY)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

        }

        public bool  VoegToe(string dier, Animal a)
        {
            if (canIAdd(a))
            {
                Console.WriteLine($"Adding {dier}");
                List.Add(a);
                return true;
            }
            else
            {
                Console.WriteLine($"{dier} cannot be added");
                return false;
            }
        }
    }
  
}
