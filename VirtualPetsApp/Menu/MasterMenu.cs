using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class MasterMenu
    {
        public Shelter shelter = new Shelter();

        public void Start()
        {

            Console.WriteLine("Welcome to Virtual Pets App! Type \"Start\" to play or press \"E\" to quit.");

            string userStart = Console.ReadLine().ToLower();
            Console.Clear();

            // Determine Start to Game
            while (userStart.Equals("start"))
            {
                Console.WriteLine("\n Would you like to create a Organic Pet or a Robotic Pet?");
                Console.WriteLine("\"O\" for an Organic Pet \n Press \"R\" for a Robotic Pet");
                Console.WriteLine("Press \"E\" to Exit");
                string menuChoice = Console.ReadLine().ToLower();
                Console.Clear();


                if (menuChoice.Equals("e"))
                {
                    userStart = "";
                }

                if (menuChoice.Equals("o"))
                {
                    Menu.OrgMenu.OrgStart(shelter);
                }
                
                if (menuChoice.Equals("r"))
                {
                    Menu.RoboMenu.CreateRoboPet(shelter);
                    Menu.RoboMenu.RoboStart(shelter);
                }

                shelter.LowerAllStats();
            }
            Console.Clear();
            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
        }

    }
}
