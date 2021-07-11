using System;
using System.Collections;

namespace OOAD
{
    public class InstrumentSpec
    {

        private Hashtable _properties;


        public InstrumentSpec(Hashtable properties)
        {
            _properties = properties == null ? new Hashtable() : new Hashtable(properties);
        }

        public Object GetPropertyValue(string propertyName)
        {
            return _properties[propertyName];
        }

        public ICollection GetPropertiesKeys()
        {
            return _properties.Keys;
        }
        public virtual bool Matches(InstrumentSpec otherSpec)
        {

            var propertyKeys = GetPropertiesKeys();

            foreach (var property in propertyKeys)
            {
                if (_properties[property] != otherSpec.GetPropertyValue(property.ToString()))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
