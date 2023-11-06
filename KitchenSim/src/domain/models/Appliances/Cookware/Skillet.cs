namespace Kitchen;
public class Skillet: ICookware, IHeatProcessing
{
    public void Prepare(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process("Fried", this);
        logger.Log($"Fried {ingredient.GetName()}.");
    }
}