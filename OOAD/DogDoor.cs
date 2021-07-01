using System;

namespace OOAD
{
    public class DogDoor
    {
        private Boolean _open;

        public DogDoor()
        {
            _open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens!");
            _open = true;
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes!");
            _open = false;
        }

        public Boolean IsOpen()
        {
            return _open;
        }


    }
}
