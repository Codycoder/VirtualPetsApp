using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsApp
{
    public class Shelter
    {
        public List<Pet> pets = new List<Pet>();

        public void AddPet(string species, string name)
        {
            Pet pet = new Pet(species, name);

            pets.Add(pet);
        }
    }
}
