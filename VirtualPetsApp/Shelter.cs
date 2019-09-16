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
    }
}
