namespace Kitchen;
public class CondimentFactory
{
    public static ICondiment CreateSpice(string name)
    {
        return new Spice(name);
    }
    public static ICondiment CreateSalt(string name)
    {
        return new Salt(name);
    }
    public static ICondiment CreateSauce(string name)
    {
        return new Sauce(name);
    }
    public static ICondiment CreateHerb(string name)
    {
        return new Herb(name);
    }
}