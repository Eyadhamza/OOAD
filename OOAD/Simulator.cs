using System;
using System.Threading;
using System.Timers;

namespace OOAD
{
    class Simulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine();
            remote.PressButton();

            Console.WriteLine("dog is out!");
            Console.WriteLine("dog is done");

            try
            {
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.WriteLine("stuck outside");
            Console.WriteLine("barking");
            Console.WriteLine("presses button again!");

            remote.PressButton();
            Console.WriteLine("back inside");
        }

    }
}
