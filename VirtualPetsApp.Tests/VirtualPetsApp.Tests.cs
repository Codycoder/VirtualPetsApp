using System;
using Xunit;

namespace VirtualPetsApp.Tests
{
    public class VirtualPetsApp
    {
        [Fact]
        public void Game_State()
        {
            var virtualPetsApp = new VirtualPetsApp();

            var result = virtualPetsApp.Start(gameStarted);

            Assert.Equal("gameStarted", result);
       
        }
    }
}
