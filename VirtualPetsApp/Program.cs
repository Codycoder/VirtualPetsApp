using System;

namespace VirtualPetsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pets App! Press P to play or any other key to quit.");

            string userStart =  Console.ReadLine().ToLower();
            // Determine Start to Game
            while (userStart.Equals("p"))
            {
                Console.WriteLine("You are In Game");
                Console.WriteLine("Press E to Exit");
                Console.WriteLine("To create a pet press A");
                string menuChoice = Console.ReadLine().ToLower();
                if (menuChoice.Equals("e"))
                {
                    userStart = "";
                }
                else if (menuChoice.Equals("a"))
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
        }
    }
}
