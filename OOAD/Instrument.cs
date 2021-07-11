namespace OOAD
{
    public class Instrument
    {
        private string _serialNumber;
        private double _price;
        private InstrumentSpec _spec;

        public InstrumentSpec Spec
        {
            get => _spec;
            set => _spec = value;
        }

        public string SerialNumber
        {
            get => _serialNumber;
            set => _serialNumber = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }


        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            _serialNumber = serialNumber;
            _price = price;
            _spec = spec;
        }
    }
}
