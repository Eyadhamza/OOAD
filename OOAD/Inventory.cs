using System.Collections.Generic;

namespace OOAD
{
    public class Inventory
    {
        private LinkedList<Guitar> _guitars;

        public LinkedList<Guitar> Guitars
        {
            get => _guitars;
            set => _guitars = value;
        }

        public Inventory(LinkedList<Guitar> guitars)
        {
            _guitars = guitars;
        }

        public void AddGuitar()
        {


        }

        public Guitar GetGuitar()
        {
            return null;
        }

        public List<Guitar> Search()
        {
            return null;
        }
    }
}
