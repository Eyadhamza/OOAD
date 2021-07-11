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

        public Instrument GetInstrument(string serialNumber) {

            foreach (Instrument instrument in _inventory)
            {
                if (instrument.SerialNumber.Equals(serialNumber)) {
                    return instrument;
                }
            }

            return null;
        }

        public List<Instrument> Search(InstrumentSpec searchSpec)
        {
            List<Instrument> matchingInstruments = new List<Instrument>();


            foreach (Instrument instrument in _inventory)
            {
                // delegation of object instrument to do the task that we want!
                if (instrument.Spec.Matches(searchSpec))
                {
                    matchingInstruments.Add(instrument);
                }
            }

            return matchingInstruments;

        }
    }
}
