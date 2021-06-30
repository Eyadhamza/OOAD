using System.Collections.Generic;

namespace OOAD
{
    public class Inventory
    {
        private List<Guitar> _guitars;

        public List<Guitar> Guitars
        {
            get => _guitars;
            set => _guitars = value;
        }

        public Inventory(List<Guitar> guitars)
        {
            _guitars = guitars;
        }


        public void AddGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood) {

            Guitar guitar = new Guitar(serialNumber, price, builder, type, backWood, topWood);

            _guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber) {

            foreach (Guitar guitar in _guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber)) {
                    return guitar;
                }
            }

            return null;
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
