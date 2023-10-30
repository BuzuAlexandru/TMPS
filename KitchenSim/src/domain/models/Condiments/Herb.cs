namespace Kitchen;

public class Herb: ICondiment, IRawProcessing
{
    public string herb;

    public Herb(string type)
    {
        this.herb= type;
    }

    public void UseCondiment(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process($"Garnished with {herb}", this);
        logger.Log($"Garnished {ingredient.name} with {herb}.");
    }
}