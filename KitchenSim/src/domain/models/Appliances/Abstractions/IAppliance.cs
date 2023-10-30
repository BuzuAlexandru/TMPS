namespace Kitchen;
public interface IAppliance
{
    public void UseAppliance(Ingredient ingredient, ILogger logger);
}