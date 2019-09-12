using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public Pet()
        {
            Hunger = 100;
            Boredom = 100;
            Health = 100;
        }


        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Pet Info" + "\n\nName " + Name + "\nSpecies: " + Species);
        }
        public void ShowPetStatus()
        {
            Console.WriteLine("Pet Status" + "\n\nHunger: " + Hunger + "\nBoredom: " + Boredom + "\nHealth " + Health);
        }    
    }
}
