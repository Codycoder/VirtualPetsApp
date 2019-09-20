using System;

namespace VirtualPetsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterMenu menu = new MasterMenu();

            

            menu.Start();

            menu.InGame();
        }
    }
}
