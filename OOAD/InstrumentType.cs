namespace OOAD
{
    public enum InstrumentType
    {
        GUITAR, BANJO, DOBRO, FIDDLE, BASS, MANDOLIN
    }

    static class InstrumentTypeMethods
    {
        public static string Value(this InstrumentType type)
        {
            switch (type)
            {
                case InstrumentType.GUITAR: return "Guitar";
                case InstrumentType.BANJO: return "Banjo";
                case InstrumentType.DOBRO: return "Dobro";
                case InstrumentType.FIDDLE: return "Fiddle";
                case InstrumentType.BASS: return "Bass";
                case InstrumentType.MANDOLIN: return "Mandolin";
                default: return "Unspecified";
            }
        }
    }
}
