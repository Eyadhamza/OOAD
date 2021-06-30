namespace OOAD
{
    public enum Wood
    {
        INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY,
    MAPLE, COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA



    }

static class WoodMethods
{
    public static string ToString(this Wood wood)
    {
        switch (wood)
        {
            case Wood.ALDER:
                return "Alder";
            case Wood.BRAZILIAN_ROSEWOOD:
                return "Brazilian Rosewood";
            default:
                return "What?!";
        }
    }
}

}
