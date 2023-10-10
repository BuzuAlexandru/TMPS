namespace Kitchen;

public class Spice: ICondiment, IRawProcessing
{
    public string spice;

    public Spice(string type)
    {
        this.spice= type;
    }

    public void Use(Ingredient ingredient)
    {
        ingredient.Process($"Spiced with {spice}", this);
        Logger.Instance.Log($"Spiced {ingredient.name} with {spice}.");
    }
}