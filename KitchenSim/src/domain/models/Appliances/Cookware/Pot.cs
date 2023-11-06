namespace Kitchen;
public class Pot: ICookware, IHeatProcessing
{
    public void Prepare(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process("Boiled", this);
        logger.Log($"Boiled {ingredient.GetName()}.");
    }
}