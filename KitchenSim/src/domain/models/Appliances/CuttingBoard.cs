namespace Kitchen;
public class CuttingBoard: IAppliance, IRawProcessing
{
    public void UseAppliance(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process("Sliced", this);
        logger.Log($"Sliced {ingredient.GetName()}.");
    }
}