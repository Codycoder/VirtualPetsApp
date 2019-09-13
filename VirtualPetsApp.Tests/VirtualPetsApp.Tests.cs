using System;
using Xunit;

namespace VirtualPetsApp.Tests
{
    public class VirtualPetsApp
    {
        [Fact]
        public void Lowering_Pet_Status_From_Menu()
        {
            //Arrange
            Pet pet = new Pet();
            //Act
            pet.LowerStats();

            //Assert
            Assert.Equal(95, pet.Hunger);
        }

        [Fact]
        public void Feed_Pet_Command()
         {
            Pet pet = new Pet();
            {
                pet.LowerStats();
            }

            pet.FeedPet();

            Assert.Equal(100, pet.Hunger);
        }
    }
}
