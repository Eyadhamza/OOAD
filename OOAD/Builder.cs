namespace OOAD
{
    public enum Builder
    {
        FENDER, MARTIN,GIBSON



    }

    static class BuilderMethods
    {
        // It's called extension methods in c#
        // Extension methods enable you to "add" methods to existing types without creating a new derived type,
        // recompiling, or otherwise modifying the original type.
        // Extension methods are static methods, but they're called as if they were instance methods on the extended type.
        // For client code written in C#, F# and Visual Basic,
        // there's no apparent difference between calling an extension method and the methods defined in a type.

        public static string Value(this Builder builder)
        {
            switch (builder)
            {
                case Builder.FENDER:
                    return "Fender";
                case Builder.MARTIN:
                    return "Martin";
                case Builder.GIBSON:
                    return "Gibson";
                default:
                    return "What?!";
            }
        }
    }
}
