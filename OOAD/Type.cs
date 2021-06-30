namespace OOAD
{
    public enum Type
    {
        ACOUSTIC, ELECTRIC



    }

    static class TypeMethods
    {
        public static string ToString(this Type type)
        {
            switch (type)
            {
                case Type.ACOUSTIC:
                    return "Acoustic";
                case Type.ELECTRIC:
                    return "Electronic";
                default:
                    return "What?!";
            }
        }
    }
}
