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
            Shelter shelter = new Shelter();

            Console.WriteLine("Welcome to Virtual Pets App! Type \"Start\" to play or any other key to quit.");

            string userStart = Console.ReadLine().ToLower();
            Console.Clear();

            // Determine Start to Game
            while (userStart.Equals("start"))
            {
                Console.WriteLine("The Object of the Game is to create a pet, and keep it happy and healthy." + "\n " + "\nKeep your hunger and boredom levels down, and your health level up!" + "\n");

                Console.WriteLine("Press E to Exit" + "\n");
                Console.WriteLine("To create a pet press \"A\"" + "\n");
                Console.WriteLine("To view your pet's info press \"I\"" + "\n");
                Console.WriteLine("To view your pet status, hit \"S\"" + "\n");
                Console.WriteLine("To feed your pet, hit \"F\"" + "\n");
                Console.WriteLine("To play your pet, hit \"P\"" + "\n");
                Console.WriteLine("To take your pet to the Doctor, hit \"D\"" + "\n");
                Console.WriteLine("To view all pets in the shelter, hit \"V\"" + "\n");
                Console.WriteLine("To feed all pets in the shelter, hit \"FF\"" + "\n");
                Console.WriteLine("To play with all pets in the shelter, hit \"PP\"" + "\n");
                Console.WriteLine("To take all pets to the Doctor from the shelter, hit \"DD\"" + "\n");
                Console.WriteLine("To view the status of all pets in the shelter, hit \"SS\"" + "\n");
                string menuChoice = Console.ReadLine().ToLower();
                Console.Clear();


                if (menuChoice.Equals("e"))
                {
                    userStart = "";
                }


                else if (menuChoice.Equals("a"))
                {
                    pet = new Pet();

                    Console.WriteLine("What kind of pet do you want?");
                    pet.Species = Console.ReadLine();
                    Console.WriteLine("What do you want to name your " + pet.Species + "?");
                    pet.Name = Console.ReadLine();
                    shelter.AddPetToList(pet);
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
                    Console.WriteLine("You have Fed Your Pet! Might Be Time for Some Exercise!");
                }
                else if (menuChoice.Equals("p"))
                {
                    pet.PlayWithPet();
                    Console.WriteLine("You Just Played With Your Pet, It's SO HAPPY!");
                }
                else if (menuChoice.Equals("v"))
                {
                    pet.DisplayList();
                    Console.WriteLine("Here are All Pets in the Shelter" + pet);
                }
                else if (menuChoice.Equals("d"))
                {
                    pet.DrugPet();
                    Console.WriteLine("You Just Took Your Pet to the Doctor. It looks MUCH Healthier!");
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
