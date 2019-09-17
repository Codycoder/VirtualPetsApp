using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class OrgPet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public OrgPet()
        {
            Hunger = 0;
            Boredom = 0;
            Health = 100;
        }
        

        public OrgPet(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public void ShowInfo()
        {
            Console.WriteLine("OrgPet Info" + "\nName " + Name + "\nSpecies: " + Species);
        }

        public void ShowPetStatus()
        {
            Console.WriteLine("OrgPet Status" + "\n\nHunger: " + Hunger + "\nBoredom: " + Boredom + "\nHealth " + Health + "\n");
        }

        public void LowerStats()
        {
            Hunger = Hunger + 5;
            Boredom = Boredom + 5;
            Health = Health - 10;
        }

        public void FeedPet()
        {
            Hunger -= 10;
        }
        public void PlayWithPet()
        {
            Boredom -= 15;
            Hunger += 15;
            Health += 15;
        }
        public void DrugPet()
        {
            Health += 15;
        }
       
    }
}
