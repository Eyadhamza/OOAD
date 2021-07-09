namespace OOAD
{
    public class GuitarSpec : InstrumentSpec
    {
        private int _numStrings;

        public GuitarSpec(int numStrings, Builder builder, string model, Type type, Wood backWood, Wood topWood) : base( builder, model, type, backWood, topWood)
        {
            _numStrings = numStrings;
        }
    }
}
