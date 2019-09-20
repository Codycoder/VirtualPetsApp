using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class Shelter
    {
        public List<Pets.Vpet> pets = new List<Pets.Vpet>();

        public void AddPetToList(Pets.Vpet pet)
        {
            pets.Add(pet);
        }
        public void ShowAllPetsInfo()
        {
            int Id = 1;
            foreach (Pets.Vpet pet in pets)
            {
                Console.Write("Pet " + Id + " ");
                pet.ShowInfo();
                Id++;
            }
        }
        public void ShowAllPetsStatus()
        {
            int Id = 1;
            foreach (Pets.Vpet pet in pets)
            {
                Console.Write("Pet " + Id + " ");
                pet.ShowPetStatus();
                Id++;
            }

        }
        public void FeedPet()
        {
            Console.WriteLine("You are feeding/oiling all your pets! \n\nPress Any Key To Continue!");
            Console.ReadKey();

            foreach (Pets.Vpet pet in pets)
            {
                pet.FeedPet();
            }
        }
        public void VetPets()
        {
            Console.WriteLine("You took all your pets to Doctor/Maintenance Shop! They are all better :) \n\nPress Any Key To Continue!");
            Console.ReadKey();

            foreach (Pets.Vpet pet in pets)
            {
                pet.DrugPet();
            }
        }
        public void PlayWithAll()
        {
            Console.WriteLine("You played with all your pets! They're SO HAPPY! \n\nPress Any Key To Continue!");
            Console.ReadKey();

            foreach (Pets.Vpet pet in pets)
            {
                pet.PlayWithPet();
            }
        } 
        public void LowerAllStats()
        {
            foreach (Pets.Vpet pet in pets)
            {
                pet.LowerStats();
            }
        }

        public void ShowAllInfoAndStatus()
        {
            foreach (Pets.Vpet pet in pets)
            {
                pet.ShowPetInfoAndStatus();
            }
        }

        public Pets.Vpet SelectOnePet()
        {
            Console.WriteLine("Select a pet by picking a number :) ");
            Pets.Vpet pet = pets[Convert.ToInt32(Console.ReadLine())-1];
            return pet;
        }

        public void AdoptAPet()
        {
            int Id = 1;

            Console.WriteLine("Select a pet to adopt by picking a number :) \n\n");

            foreach (Pets.Vpet pet in pets)
            {
                Console.Write("Pet " + Id + " ");
                pet.ShowInfo();
                Id++;
            }
            Pets.Vpet adoptedPet = pets[Convert.ToInt32(Console.ReadLine()) - 1];

            Console.Clear();
            Console.WriteLine("Your pet was Adopted :) \nPress Any Key To Continue!");
            Console.ReadKey();

            pets.Remove(adoptedPet);
        }
    }
}
