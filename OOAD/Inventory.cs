using System;
using System.Collections.Generic;

namespace OOAD
{
    public class Inventory
    {
        private List <Instrument> _inventory;

        public List<Instrument> Inventory1
        {
            get => _inventory;
            set => _inventory = value;
        }


        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = new Instrument(serialNumber, price, spec);

            _inventory.Add(instrument);
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
