using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp.Menu
{
    public class OrgMenu : MasterMenu
    {
        static public void OrgStart()
        {
            OrgPet pet = new OrgPet();

            Console.WriteLine("Welcome to Virtual Pets App! Type \"Start\" to play or any other key to quit.");

            string userStart = Console.ReadLine().ToLower();
            Console.Clear();

            // Determine Start to Game
            while (userStart.Equals("start"))
            {
                Console.WriteLine("______________________________________________________________________________________________ \n");
                Console.WriteLine("The Object of the Game is to create a pet, and keep it happy and healthy.                     |\n \nKeep your hunger and boredom levels down, and your health level up!                           |\n");

                Console.WriteLine("\"E\" To exit            | \"A\" Create pet              | \"I\" View pet info                      |\n");

                Console.WriteLine("\"S\" View pet status    | \"F\" Feed pet                | \"P\" Play with OrgPet                      |\n");

                Console.WriteLine("\"D\" OrgPet to Vet         | \"II\" View shelter pets                                               |\n");

                Console.WriteLine("\"FF\" Feed shelter pets | \"PP\" Play with shelter pets | \"DD\" Take shelter pets to vet          |");

                Console.WriteLine("______________________________________________________________________________________________");

                string menuChoice = Console.ReadLine().ToLower();
                Console.Clear();


                if (menuChoice.Equals("e"))
                {
                    userStart = "";
                }


                else if (menuChoice.Equals("a"))
                {
                    pet = new OrgPet();

                    Console.WriteLine("What kind of pet do you want?");
                    pet.Species = Console.ReadLine();
                    Console.WriteLine("What do you want to name your " + pet.Species + "?");
                    pet.Name = Console.ReadLine();
                    shelter.AddPetToList(pet);
                    Console.Clear();
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

                else if (menuChoice.Equals("ii"))
                {
                    shelter.ShowAllPetsInfo();
                }

                else if (menuChoice.Equals("f"))
                {
                    pet.FeedPet();
                    Console.WriteLine("You have Fed Your OrgPet! Might Be Time for Some Exercise! \n");
                }

                else if (menuChoice.Equals("ff"))
                {
                    shelter.FeedPet();
                    Console.WriteLine("You have Fed Your Pets! Might Be Time for Some Exercise! \n");
                }

                else if (menuChoice.Equals("p"))
                {
                    pet.PlayWithPet();
                    Console.WriteLine("You Just Played With Your OrgPet, It's SO HAPPY! \n");
                }

                else if (menuChoice.Equals("pp"))
                {
                    shelter.PlayWithAll();
                    Console.WriteLine("You just played with all of your pets, they are SOOO happy!\n");
                }

                else if (menuChoice.Equals("d"))
                {
                    pet.DrugPet();
                    Console.WriteLine("You Just Took Your OrgPet to the Doctor. It looks MUCH Healthier! \n");
                }

                else if (menuChoice.Equals("dd"))
                {
                    shelter.VetPets();
                    Console.WriteLine("You just took all of your pets to the Doctor. They look MUCH healthier! \n");
                }
                shelter.LowerAllStats();
            }
            Console.Clear();
            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
        }
    }
}