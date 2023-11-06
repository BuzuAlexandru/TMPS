namespace Kitchen;

public class Sauce: ICondiment, IRawProcessing
{
    public string sauce;

    public Sauce(string type)
    {
        this.sauce= type;
    }

    public void UseCondiment(Ingredient ingredient, ILogger logger)
    {
        ingredient.Process($"With {this.sauce}", this);
        logger.Log($"Added {sauce} to {ingredient.GetName()}.");
    }
}