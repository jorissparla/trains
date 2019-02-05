using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWagons
{
    enum AnimalType
    {
        Carnivore=1,
        Herbivore=2
    }

    enum AnimalSize
    {
        small = 1,
        medium =3,
        large = 5
    }
    class Animal
    {
        AnimalType _type;
        AnimalSize _size;
        public Animal(AnimalType type, AnimalSize size )
        {
            Type = type;
            Size = size;

        }

        public AnimalSize Size { get => _size; set => _size = value; }
        public AnimalType Type { get => _type; set => _type = value; }
    }
}
