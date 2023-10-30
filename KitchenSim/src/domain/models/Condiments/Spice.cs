namespace Kitchen;

public class Spice: ICondiment, IRawProcessing
{
    public string spice;

    public Spice(string type)
    {
        this.spice= type;
    }

    public void UseCondiment(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process($"Spiced with {spice}", this);
        logger.Log($"Spiced {ingredient.name} with {spice}.");
    }
}