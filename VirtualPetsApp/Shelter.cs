using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class Shelter
    {
        public List<OrgPet> pets = new List<OrgPet>();

        public void AddPetToList(OrgPet pet)
        {
         
            pets.Add(pet);
        }
        public void ShowAllPetsInfo()
        {
            foreach (OrgPet pet in pets)
            {
                pet.ShowInfo();
                pet.ShowPetStatus();
            }
        }
        public void ShowAllPetsStatus()
        {  
            foreach(OrgPet pet in pets)
            {
                pet.ShowPetStatus(); 
            }

        }
        public void FeedPet()
        {
            foreach (OrgPet pet in pets)
            {
                pet.FeedPet();
            }
        }
        public void VetPets()
        {
            foreach (OrgPet pet in pets)
            {
                pet.DrugPet();
            }
        }
        public void PlayWithAll()
        {
            foreach (OrgPet pet in pets)
            {
                pet.PlayWithPet();
            }
        } 
        public void LowerAllStats()
        {
            foreach (OrgPet pet in pets)
            {
                pet.LowerStats();
            }
        }
    }
}
