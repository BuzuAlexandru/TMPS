namespace Kitchen;

public class Sauce: ICondiment, IRawProcessing
{
    public string sauce;

    public Sauce(string type)
    {
        this.sauce= type;
    }

    public void Use(Ingredient ingredient)
    {
        ingredient.Process($"With {this.sauce}", this);
        Logger.Instance.Log($"Added {sauce} to {ingredient.name}.");
    }
}