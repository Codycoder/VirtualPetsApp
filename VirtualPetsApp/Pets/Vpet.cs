using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp.Pets
{
    public class Vpet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Boredom { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }

        public Vpet()
        {
            Hunger = 0;
            Boredom = 0;
            Health = 100;
        }


        public Vpet(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Organic Pet Info" + "\nName " + Name + "\nSpecies: " + Species);
        }

        public virtual void ShowPetStatus()
        {
            Console.WriteLine("Organic Pet Status" + "\n\nHunger: " + Hunger + "\nBoredom: " + Boredom + "\nHealth " + Health + "\n");
        }

        public virtual void ShowPetInfoAndStatus()
        {
            Console.WriteLine("Organic Pet Info" + "\nName " + Name + "\nSpecies: " + Species);
            Console.WriteLine("\nOrganic Pet Status" + "\n\nHunger: " + Hunger + "\nBoredom: " + Boredom + "\nHealth " + Health + "\n");
        }

        public virtual void LowerStats()
        {
            Hunger = Hunger + 1;
            Boredom = Boredom + 1;
            Health = Health - 1;
        }

        public virtual void FeedPet()
        {
            Hunger -= 1;
        }
        public virtual void PlayWithPet()
        {
            Boredom -= 10;
            Hunger += 5;
            Health += 5;
        }
        public virtual void DrugPet()
        {
            Health += 15;
        }
    }
}
