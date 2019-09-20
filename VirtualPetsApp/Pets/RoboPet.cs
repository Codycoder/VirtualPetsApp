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
            Console.WriteLine($"You gave your Robo pet {Name} oil! \n\nPress Any Key To Continue!");
            Console.ReadKey();

            Hunger = OilLevel +1; 
        }

        public override void PlayWithPet()
        {
            Console.WriteLine($"You are charging your Robo Pet {Name}! It's SO HAPPY! \n\nPress Any Key To Continue!");
            Console.ReadKey();

            Hunger = OilLevel += 5;
            Health = PerformanceLevel += 5;
        }
        public override void DrugPet()
        {
            Console.WriteLine($"You giving your Robo Pet {Name} a tune up! It runs much better now :) \n\nPress Any Key To Continue!");
            Console.ReadKey();

            Health = PerformanceLevel += 15;
        }

    }
}
