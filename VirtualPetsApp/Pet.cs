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
            Hunger = 0;
            Boredom = 0;
            Health = 100;
        }
        

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Pet Info" + "\nName " + Name + "\nSpecies: " + Species);
        }

        public void ShowPetStatus()
        {
            Console.WriteLine("Pet Status" + "\n\nHunger: " + Hunger + "\nBoredom: " + Boredom + "\nHealth " + Health + "\n");
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
        public void DisplayList()
        {
            // Console.WriteLine(pet);
        }
    }
}
