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
            foreach (Pets.Vpet pet in pets)
            {
                pet.ShowInfo();
                pet.ShowPetStatus();
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
    }
}
