namespace Kitchen;
public class Oven: IAppliance, IHeatProcessing
{
    public void UseAppliance(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process("Baked", this);
        logger.Log($"Baked {ingredient.GetName()}.");
    }
}