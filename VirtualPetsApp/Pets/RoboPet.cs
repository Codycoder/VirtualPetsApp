using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp.Pets
{
    class RoboPet : Pets.Vpet
    {
        public int OilLevel { get; set; }
        public int PerformanceLevel { get; set; }

        public RoboPet() : base()
        {
            Hunger = OilLevel + 100;
            Health = PerformanceLevel;
        }

        public RoboPet(string name, string species) : base(name, species)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Robotic Pet Info" + "\nName " + Name + "\nSpecies: " + Species);
        }

        public override void ShowPetStatus()
        {
            Console.WriteLine("Robotic Pet Status" + "\n\nHunger: " + Hunger + "\nBoredom: " + Boredom + "\nHealth " + Health + "\n");
        }

        public override void ShowPetInfoAndStatus()
        {
            Console.WriteLine("Robotic Pet Info" + "\nName " + Name + "\nSpecies: " + Species);
            Console.WriteLine("\nRobotic Pet Status" + "\n\nHunger: " + Hunger + "\nBoredom: " + Boredom + "\nHealth " + Health + "\n");
        }


        public override void LowerStats()
        {
            Hunger = OilLevel -1;
            Health = PerformanceLevel - 1;
        }

        public override void FeedPet()
        {
            Hunger = OilLevel +1; 
        }

        public override void PlayWithPet()
        {
            Hunger = OilLevel += 5;
            Health = PerformanceLevel += 5;
        }
        public override void DrugPet()
        {
            Health = PerformanceLevel += 15;
        }

    }
}
