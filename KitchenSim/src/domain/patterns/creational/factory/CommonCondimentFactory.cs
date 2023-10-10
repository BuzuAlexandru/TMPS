namespace Kitchen;
public class CommonCondimentFactory: ICondimentFactory
{
    public ICondiment CreateHerb()
    {
        return new Herb("Parsley");
    }
    public ICondiment CreateSalt()
    {
        return new Salt("Table salt");
    }
    public ICondiment CreateSpice()
    {
        return new Spice("Black pepper");
    }
}