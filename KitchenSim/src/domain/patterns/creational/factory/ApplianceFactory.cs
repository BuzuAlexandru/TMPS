namespace Kitchen;
public class ApplianceFactory
{
    public static IAppliance CreateCuttingBoard()
    {
        return new CuttingBoard();
    }
    public static IAppliance CreateGrill()
    {
        return new Grill();
    }
    public static IAppliance CreateOven()
    {
        return new Oven();
    }
    public static IAppliance CreateStove(ICookware cookware)
    {
        return new Stove(cookware);
    }
}