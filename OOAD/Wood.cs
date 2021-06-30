namespace OOAD
{
    public enum Wood
    {
        INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY,
    MAPLE, COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA



    }

static class WoodMethods
{
    public static string toString(this Wood wood)
    {
        switch (wood)
        {
            case Wood.INDIAN_ROSEWOOD:
                return "Indian Rosewood";
            case Wood.BRAZILIAN_ROSEWOOD:
                return "Brazilian Rosewood";
            default:
                return "What?!";
        }
    }
}

}
