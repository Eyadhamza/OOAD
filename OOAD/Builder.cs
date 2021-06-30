namespace OOAD
{
    public enum Builder
    {
        FENDER, MARTIN



    }

    static class BuilderMethods
    {
        public static string ToString(this Builder builder)
        {
            switch (builder)
            {
                case Builder.FENDER:
                    return "Fender";
                case Builder.MARTIN:
                    return "Martin";
                default:
                    return "What?!";
            }
        }
    }
}
