using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class Shelter
    {
        public List<Pet> pets = new List<Pet>();

        public void AddPetToList(Pet pet)
        {
         
            pets.Add(pet);
        }
        public void ShowAllPetsInfo()
        {
            foreach (Pet pet in pets)
            {
                pet.ShowInfo();
                pet.ShowPetStatus();
            }
        }
        public void ShowAllPetsStatus()
        {  
            foreach(Pet pet in pets)
            {
                pet.ShowPetStatus(); 
            }

        }
        public void FeedPet()
        {
            foreach (Pet pet in pets)
            {
                pet.FeedPet();
            }
        }
        public void VetPets()
        {
            foreach (Pet pet in pets)
            {
                pet.DrugPet();
            }
        }
        public void PlayWithAll()
        {
            foreach (Pet pet in pets)
            {
                pet.PlayWithPet();
            }
        } 
        public void LowerAllStats()
        {
            foreach (Pet pet in pets)
            {
                pet.LowerStats();
            }
        }
    }
}
