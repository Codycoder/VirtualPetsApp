using System;
using Xunit;

namespace VirtualPetsApp.Tests
{
    public class VirtualPetsApp
    {
        private int status;

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
    }
}
