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
                Console.Write("ID " + Id + " ");
                pet.ShowInfo();
                Id++;
            }
        }
        public void ShowAllPetsStatus()
        {  
            foreach(Pets.Vpet pet in pets)
            {
                pet.ShowPetStatus(); 
            }

        }
        public void FeedPet()
        {
            foreach (Pets.Vpet pet in pets)
            {
                pet.FeedPet();
            }
        }
        public void VetPets()
        {
            foreach (Pets.Vpet pet in pets)
            {
                pet.DrugPet();
            }
        }
        public void PlayWithAll()
        {
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

        public Pets.Vpet SelectOnePet()
        {
            Console.WriteLine("Select a pet by picking a number :) ");
            Pets.Vpet pet = pets[Convert.ToInt32(Console.ReadLine())-1];
            return pet;
        }
    }
}
