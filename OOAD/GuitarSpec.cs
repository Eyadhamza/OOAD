using System;

namespace OOAD
{
    public class GuitarSpec : InstrumentSpec
    {
        private int _numStrings;

        public GuitarSpec(int numStrings, Builder builder, string model, Type type, Wood backWood, Wood topWood) : base( builder, model, type, backWood, topWood)
        {
            _numStrings = numStrings;
        }


        public override bool Matches(InstrumentSpec otherSpec)
        {
            if (!base.Matches(otherSpec))
            {
                return false;
            }

            if (!(otherSpec.GetType() == typeof(GuitarSpec)))
            {
                return false;
            }

            GuitarSpec spec = (GuitarSpec) otherSpec;
            if (_numStrings != spec._numStrings)
            {
                return false;
            }

            return true;
        }
    }
}
