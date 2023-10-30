namespace Kitchen;

public class Salt: ICondiment, IRawProcessing
{
    public string type;

    public Salt(string type)
    {
        this.type = type;
    }

    public void UseCondiment(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process($"Salted with {type}", this);
        logger.Log($"Salted {ingredient.name} with {type}.");
    }
}