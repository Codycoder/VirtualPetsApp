using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public Pet()
        {
           // Info = name; specie;
        }
        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Pet Info" + "\nName "+ Name + "\nSpecies: " + Species);
        }
    }
}
