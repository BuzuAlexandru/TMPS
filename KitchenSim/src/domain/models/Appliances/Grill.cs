namespace Kitchen;
public class Grill: IAppliance, IHeatProcessing
{
    public void UseAppliance(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process("Grilled", this);
        logger.Log($"Grilled {ingredient.GetName()}.");
    }
}