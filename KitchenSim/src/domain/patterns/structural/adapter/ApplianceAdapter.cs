namespace Kitchen;
public class ApplianceAdapter: ICondiment
{
    private readonly IAppliance appliance;

    public ApplianceAdapter(IAppliance appl)
    {
        appliance= appl;
    }

    public void UseCondiment(Ingredient ingredient, ILogger logger)
    {
        appliance.UseAppliance(ingredient, logger);
    }
}