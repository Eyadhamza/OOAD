namespace OOAD
{
    public class GuitarSpec
    {
        private Builder _builder;
        private string _model;
        private Type _type;
        private Wood _backWood;
        private Wood _topWood;
        private int _numStrings;

        public int NumStrings
        {
            get => _numStrings;
            set => _numStrings = value;
        }

        public Builder Builder
        {
            get => _builder;
            set => _builder = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public Type Type
        {
            get => _type;
            set => _type = value;
        }

        public Wood BackWood
        {
            get => _backWood;
            set => _backWood = value;
        }

        public Wood TopWood
        {
            get => _topWood;
            set => _topWood = value;
        }

        public GuitarSpec(int numStrings,Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _backWood = backWood;
            _topWood = topWood;
            this._numStrings = numStrings;
        }

        public bool Matches(GuitarSpec guitarSpec)
        {
            if (_builder != guitarSpec.Builder)
               return false;
            string model = _model.ToLower();
            if ((!model.Equals("")) &&
                (!model.Equals(guitarSpec.Model.ToLower())))
                return false;
            if (_type != guitarSpec.Type)
               return false;
            if (_backWood != guitarSpec.BackWood)
               return false;
            if (_topWood != guitarSpec.TopWood)
               return false;

            return true;
        }
    }
}
