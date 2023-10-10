namespace Kitchen;
public class FancyCondimentFactory: ICondimentFactory
{
    public ICondiment CreateHerb()
    {
        return new Herb("Saffron");
    }
    public ICondiment CreateSalt()
    {
        return new Salt("Icelandic Lava Salt");
    }
    public ICondiment CreateSpice()
    {
        return new Spice("Turmeric");
    }
}