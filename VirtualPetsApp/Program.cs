using System;

namespace VirtualPetsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pets App! Press P to play or any other key to quit.");

            string userStart =  Console.ReadLine().ToLower();

            while (userStart.Equals("p"))
            {
                Console.WriteLine("You are In Game");
                Console.WriteLine("Press E to Exit");
                string userChoice = Console.ReadLine().ToLower();
                if (userChoice.Equals("e"))
                {
                    userStart = "";
                }
                

            }

            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
        }
    }
}
