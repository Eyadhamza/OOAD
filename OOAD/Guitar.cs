namespace OOAD
{
    public class Guitar
    {
        private string _serialNumber;
        private double _price;
        private GuitarSpec _spec;

        public Guitar(GuitarSpec spec)
        {
            _spec = spec;
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

        public GuitarSpec Spec
        {
            get => _spec;
            set => _spec = value;
        }

        public Guitar(GuitarSpec spec, double price, string serialNumber)
        {
            this._spec = spec;
            this._price = price;
            this._serialNumber = serialNumber;

            // this._spec = new GuitarSpec();
        }


    }
}
