using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class Menu
    {
        public void Start()
        {
            Pet pet = new Pet();


            Console.WriteLine("Welcome to Virtual Pets App! Type \"Start\" to play or any other key to quit.");

            string userStart = Console.ReadLine().ToLower();
            Console.Clear();

            // Determine Start to Game
            while (userStart.Equals("start"))
            {
                Console.WriteLine("You are In Game");
                Console.WriteLine("Press E to Exit");
                Console.WriteLine("To create a pet press \"A\"");
                Console.WriteLine("To view your pet's info press \"I\"");
                Console.WriteLine("To view your pet status, hit \"S\"");
                Console.WriteLine("To feed your pet, hit \"F\"");
                Console.WriteLine("To play your pet, hit \"P\"");
                Console.WriteLine("To take your pet to the doc, hit \"D\"");
                string menuChoice = Console.ReadLine().ToLower();
                Console.Clear();


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
                    Console.Clear();
                    pet.ShowInfo();
                    Console.WriteLine(" ");
                }


                else if (menuChoice.Equals("s"))
                {
                    pet.ShowPetStatus();
                }


                else if (menuChoice.Equals("i"))
                {
                    pet.ShowInfo();
                }
                

                else if (menuChoice.Equals("f"))
                {
                    pet.FeedPet();
                }
                else if (menuChoice.Equals("p"))
                {
                    pet.PlayWithPet();
                }
                else if (menuChoice.Equals("d"))
                {
                    pet.DrugPet();
                }
                pet.ShowPetStatus();
                pet.LowerStats();
            }
            Console.Clear();
            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
        }

    }
}
