using System;
using Xunit;

namespace VirtualPetsApp.Tests
{
    public class OrgPetTests
    {
        [Fact]
        public void Lowering_Pet_Status_From_Menu()
        {
            //Arrange
            OrgPet pet = new OrgPet();
            //Act
            pet.LowerStats();

            //Assert
            Assert.Equal(95, pet.Hunger);
        }

        [Fact]
        public void Feed_Pet_Command()
         {
            OrgPet pet = new OrgPet();
            {
                pet.LowerStats();
            }

            pet.FeedPet();

            Assert.Equal(100, pet.Hunger);
        }
    }
}
