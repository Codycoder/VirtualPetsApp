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
                Console.WriteLine(" __   __ __   ______  ______  __  __   ______   __           ______  ______  ______  ______ ");
                Console.WriteLine("/\\ \\ / //\\ \\ /\\  == \\/\\__  _\\/\\ \\/\\ \\ /\\  __ \\ /\\ \\         /\\  == \\/\\  ___\\/\\__  _\\/\\  ___\\");
                Console.WriteLine("\\ \\ \\'/ \\ \\ \\\\ \\  __<\\/_/\\ \\/\\ \\ \\_\\ \\\\ \\  __ \\\\ \\ \\____    \\ \\  _-/\\ \\  __\\\\/_/\\ \\/\\ \\___  \\");
                Console.WriteLine(" \\ \\__|  \\ \\_\\\\ \\_\\ \\_\\ \\ \\_\\ \\ \\_____\\\\ \\_\\ \\_\\\\ \\_____\\    \\ \\_\\   \\ \\_____\\ \\ \\_\\ \\/\\_____\\");
                Console.WriteLine("  \\/_/    \\/_/ \\/_/ /_/  \\/_/  \\/_____/ \\/_/\\/_/ \\/_____/     \\/_/    \\/_____/  \\/_/  \\/_____/\n");
                Console.WriteLine("\t ______   __   __    __   __  __   __       ______   ______  ______   ______  ");
                Console.WriteLine("\t/\\  ___\\ /\\ \\ /\\ \"-./  \\ /\\ \\/\\ \\ /\\ \\     /\\  __ \\ /\\__  _\\/\\  __ \\ /\\  == \\  ");
                Console.WriteLine("\t\\ \\___  \\\\ \\ \\\\ \\ \\-./\\ \\\\ \\ \\_\\ \\\\ \\ \\____\\ \\  __ \\\\/_/\\ \\/\\ \\ \\/\\ \\\\ \\  __< ");
                Console.WriteLine("\t \\/\\_____\\\\ \\_\\\\ \\_\\ \\ \\_\\\\ \\_____\\\\ \\_____\\\\ \\_\\ \\_\\  \\ \\_\\ \\ \\_____\\\\ \\_\\ \\_\\");
                Console.WriteLine("\t  \\/_____/ \\/_/ \\/_/  \\/_/ \\/_____/ \\/_____/ \\/_/\\/_/   \\/_/  \\/_____/ \\/_/ /_/     V3.5");
                Console.WriteLine("");

                Console.WriteLine("\n\n\t __         ___ __     __                   ||       ___        ___ __     __     o ___    ");
                Console.WriteLine("\t|__)   __    | /  \\   |__)|    /\\ \\ /       ||      |__    __    | /  \\   |__ \\_/ |  |      ");
                Console.WriteLine("\t|            | \\__/   |   |__ /--\\ |        ||      |___         | \\__/   |__ / \\ |  |      ");
                Console.WriteLine("\t\t\t\t\t\t    ||");


                string menuChoice = Console.ReadLine().ToLower();
                Console.Clear();


                if (menuChoice.Equals("e"))
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for playing!!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                else if (menuChoice.Equals("p"))
                {
                    userStart = false;
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

                    Console.WriteLine("\"E\" To exit            | \"C\" Create pet      | \"A\" Adopt a pet                       |\n");

                    Console.WriteLine("\"SS\" View pet status    | \"F\" Feed pet                | \"P\" Play with Pet                      |\n");

                    Console.WriteLine("\"D\" Care for pet         | \"II\" View shelter pets                                               |\n");

                    Console.WriteLine("\"FF\" Feed shelter pets | \"PP\" Play with shelter pets | \"DD\" Take shelter pets to vet          |");

                    Console.WriteLine("______________________________________________________________________________________________");

                    string menuChoice = Console.ReadLine().ToLower();
                    Console.Clear();


                    if (menuChoice.Equals("e"))
                    {
                        ExitGame();
                    }


                    else if (menuChoice.Equals("c"))
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

                    else if (menuChoice.Equals("a"))
                    {
                        Console.Clear();
                        shelter.AdoptAPet();
                        Console.Clear();
                    }

                    else if (menuChoice.Equals("ss"))
                    {
                        shelter.ShowAllPetsStatus();
                    }

                    else if (menuChoice.Equals("ii"))
                    {
                        shelter.ShowAllPetsInfo();
                    }

                    else if (menuChoice.Equals("f"))
                    {
                        Console.Clear();
                        shelter.ShowAllPetsInfo();
                        pet = shelter.SelectOnePet();
                        pet.ShowPetInfoAndStatus();
                        pet.FeedPet();
                        Console.Clear();
                        pet.ShowPetInfoAndStatus();
                    }

                    else if (menuChoice.Equals("ff"))
                    {
                        Console.Clear();
                        shelter.ShowAllInfoAndStatus();
                        shelter.FeedPet();
                        Console.Clear();
                        shelter.ShowAllInfoAndStatus();
                    }

                    else if (menuChoice.Equals("p"))
                    {
                        Console.Clear();
                        shelter.ShowAllPetsInfo();
                        pet = shelter.SelectOnePet();
                        pet.PlayWithPet();
                        Console.Clear();
                        pet.ShowPetInfoAndStatus();
                    }

                    else if (menuChoice.Equals("pp"))
                    {
                        Console.Clear();
                        shelter.ShowAllInfoAndStatus();
                        shelter.PlayWithAll();
                        Console.Clear();
                        shelter.ShowAllInfoAndStatus();
                    }

                    else if (menuChoice.Equals("d"))
                    {
                        Console.Clear();
                        shelter.ShowAllPetsInfo();
                        pet = shelter.SelectOnePet();
                        pet.DrugPet();
                        Console.Clear();
                        pet.ShowPetInfoAndStatus();
                    }

                    else if (menuChoice.Equals("dd"))
                    {
                        Console.Clear();
                        shelter.ShowAllInfoAndStatus();
                        shelter.VetPets();
                        shelter.ShowAllInfoAndStatus();
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


