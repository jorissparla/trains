using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWagons
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

            Animal largeCarnivore = new Animal ( AnimalType.Carnivore, AnimalSize.large );
            Animal mediumCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.medium);
            Animal smallCarnivore = new Animal(AnimalType.Carnivore, AnimalSize.small);
            Animal largeHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.large);
            Animal mediumHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.medium);
            Animal smallHerbivore = new Animal(AnimalType.Herbivore, AnimalSize.small);

            Wagon newWagon = new Wagon();

            Train trein = new Train();
            trein.VoegToe("Leeuw", mediumCarnivore);

            trein.VoegToe("paard", largeHerbivore);
            trein.VoegToe("Leeuw", mediumCarnivore);

            trein.VoegToe("paard", largeHerbivore);
            trein.VoegToe("Leeuw", mediumCarnivore);

            trein.VoegToe("paard", largeHerbivore);
         
            Console.ReadKey();


        }

        

    }
}
