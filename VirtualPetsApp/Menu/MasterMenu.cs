using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class MasterMenu
    {
        public void Start()
        {
            Shelter shelter = new Shelter();

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
                    Menu.OrgMenu.OrgStart();
                }
                
                if (menuChoice.Equals("r"))
                {
                    Menu.RoboMenu.RoboStart();
                }

                shelter.LowerAllStats();
            }
            Console.Clear();
            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
        }

    }
}
