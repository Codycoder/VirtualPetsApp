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

            bool userStart = true; 
            
            while (userStart)
            {
                Console.WriteLine("Welcome to Virtual Pets App! Type \"Start\" to play or press \"E\" to quit.");

                Console.WriteLine("\n Would you like to create a Organic Pet or a Robotic Pet?");
                Console.WriteLine("\"O\" for an Organic Pet \n Press \"R\" for a Robotic Pet");
                Console.WriteLine("Press \"E\" to Exit");

                string menuChoice = Console.ReadLine().ToLower();
                Console.Clear();


                if (menuChoice.Equals("e"))
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for playing!!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (menuChoice.Equals("start"))
                {
                    
                }
            }
        }

        public void InGame()
        {
            Pets.RoboPet roboPet = new Pets.RoboPet();
            OrgPet orgPet = new OrgPet();
            Pets.Vpet pet = new Pets.Vpet();

            {
                bool userStart = true;

                while (userStart == true)
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
                        ExitGame();
                    }


                    else if (menuChoice.Equals("a"))
                    {
                        Console.WriteLine("\n Would you like to create a Organic Pet or a Robotic Pet?");
                        Console.WriteLine("\"O\" for an Organic Pet \n Press \"R\" for a Robotic Pet");
                        Console.WriteLine("Press \"E\" to Exit");
                        menuChoice = Console.ReadLine().ToLower();
                        Console.Clear();


                        if (menuChoice.Equals("e"))
                        {
                            Console.Clear();
                            Console.WriteLine("Thanks for playing!!");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }

                        if (menuChoice.Equals("o"))
                        {
                            orgPet = new OrgPet();

                            Console.WriteLine("What kind of Organic pet do you want?");
                            orgPet.Species = Console.ReadLine();
                            Console.WriteLine("What do you want to name your " + orgPet.Species + "?");
                            orgPet.Name = Console.ReadLine();

                            shelter.AddPetToList(orgPet);


                            Console.Clear();
                            Console.WriteLine(" ");
                        }

                        if (menuChoice.Equals("r"))
                        {
                            roboPet = new Pets.RoboPet();

                            Console.WriteLine("What kind of Robotic pet do you want?");
                            roboPet.Species = Console.ReadLine();
                            Console.WriteLine("What do you want to name your " + roboPet.Species + "?");
                            roboPet.Name = Console.ReadLine();

                            shelter.AddPetToList(roboPet);


                            Console.Clear();
                            Console.WriteLine(" ");
                        }


                    }

                    else if (menuChoice.Equals("ii"))
                    {
                        shelter.ShowAllPetsInfo();
                    }

                    else if (menuChoice.Equals("f"))
                    {
                        shelter.ShowAllPetsInfo();
                        pet = shelter.SelectOnePet();
                        pet.FeedPet();
                        Console.WriteLine("You have Fed Your Pet! Might Be Time for Some Exercise! \n");
                    }

                    else if (menuChoice.Equals("ff"))
                    {
                        shelter.FeedPet();
                        Console.WriteLine("You have Fed Your Pets! Might Be Time for Some Exercise! \n");
                    }

                    else if (menuChoice.Equals("p"))
                    {
                        shelter.ShowAllPetsInfo();
                        pet = shelter.SelectOnePet();
                        pet.PlayWithPet();
                        Console.WriteLine("You Just Played With Your Pet , It's SO HAPPY! \n");
                    }

                    else if (menuChoice.Equals("pp"))
                    {
                        shelter.PlayWithAll();
                        Console.WriteLine("You just played with all of your pets, they are SOOO happy!\n");
                    }

                    else if (menuChoice.Equals("d"))
                    {
                        shelter.ShowAllPetsInfo();
                        pet = shelter.SelectOnePet();
                        pet.DrugPet();
                        Console.WriteLine("You Just Took Your Pet to the Doctor. It looks MUCH Healthier! \n");
                    }

                    else if (menuChoice.Equals("dd"))
                    {
                        shelter.VetPets();
                        Console.WriteLine("You just took all of your pets to the Doctor. They look MUCH healthier! \n");
                    }
                    shelter.LowerAllStats();
                }


            }
        }

        public void ExitGame()
        {
            Console.Clear();
            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}


