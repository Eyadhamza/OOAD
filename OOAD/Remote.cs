using System;
using System.Timers;

namespace OOAD
{
    public class Remote
    {
        private static Timer aTimer;

        private DogDoor _door;

        public Remote(DogDoor door)
        {
            this._door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("pressing the remote control button.. ");

            if (_door.IsOpen())
            {
                _door.Close();
            }
            else
            {
                _door.Open();


                // Create a timer and set a two second interval.
                aTimer = new Timer {Interval = 2000};

                // Hook up the Elapsed event for the timer.
                aTimer.Elapsed += OnTimedEvent;

                // Have the timer fire repeated events (true is the default)

                // Start the timer
                aTimer.Enabled = true;


                Console.ReadLine();
            }
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
           _door.Close();
           aTimer.Stop();
        }
    }
}
