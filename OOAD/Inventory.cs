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

        public List<Guitar> GetGuitar()
        {


        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in matchingGuitars)
            {
                GuitarSpec guitarSpec = guitar.Spec;
                if (searchSpec.Builder != guitarSpec.Builder)
                    continue;
                string model = searchSpec.Model.ToLower();
                if ((!model.Equals("")) &&
                    (!model.Equals(guitarSpec.Model.ToLower())))
                    continue;
                if (searchSpec.Type != guitarSpec.Type)
                    continue;
                if (searchSpec.BackWood != guitarSpec.BackWood)
                    continue;
                if (searchSpec.TopWood != guitarSpec.TopWood)
                    continue;
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;

        }
    }
}
