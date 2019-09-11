using System;

namespace VirtualPetsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();


            Console.WriteLine("Welcome to Virtual Pets App! Press P to play or any other key to quit.");

            string userStart =  Console.ReadLine().ToLower();
            // Determine Start to Game
            while (userStart.Equals("p"))
            {
                Console.WriteLine("You are In Game");
                Console.WriteLine("Press E to Exit");
                Console.WriteLine("To create a pet press A");
                string menuChoice = Console.ReadLine();
                if (menuChoice.Equals("e"))
                {
                    userStart = "";
                }
                else if (menuChoice.Equals("a"))
                {
                    Console.WriteLine("What kind of pet do you want?");
                    pet.Species = Console.ReadLine();
                    Console.WriteLine("What do you want to name your " + pet.Species + "?");
                    pet.Name = Console.ReadLine();
                    pet.ShowInfo();
                }
            }

            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
        }
    }
}
