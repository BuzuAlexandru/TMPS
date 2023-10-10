namespace Kitchen;
public class CookwareFactory
{
    public static ICookware CreatePot()
    {
        return new Pot();
    }
    public static ICookware CreateSkillet()
    {
        return new Skillet();
    }
}