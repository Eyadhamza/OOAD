using System;
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

        public Inventory()
        {
             this._guitars =new List<Guitar>();
        }


        public void AddGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {

            GuitarSpec spec = new GuitarSpec(10,builder, model, type, backWood, topWood);

             Guitar guitar = new Guitar(serialNumber, price,spec);


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


            foreach (Guitar guitar in _guitars)
            {
                // delegation of object guitar to do the task that we want!
                if (guitar.Spec.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;

        }
    }
}
