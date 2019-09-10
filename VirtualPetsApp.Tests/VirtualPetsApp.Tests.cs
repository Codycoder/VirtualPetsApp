using System;
using Xunit;

namespace VirtualPetsApp.Tests
{
    public class VirtualPetsApp
    {
        [Fact]
        public void Pet_Has_Name()
        {
            Pet userPets = new Pet();

            userPets.Name = "name";

            Assert.Equal("name", userPets.Name);
        }
    }
}