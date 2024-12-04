using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLinq
{
    public class Animal
    {

        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Colour { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsVaccinated { get; set; }
        public Animal(string name, string species, int age, string colour, int numOfLegs, bool isVaccinated)
        {
            Name = name;
            Species = species;
            Age = age;
            Colour = colour;
            NumberOfLegs = numOfLegs;
            IsVaccinated = isVaccinated;
        }

    }
}
