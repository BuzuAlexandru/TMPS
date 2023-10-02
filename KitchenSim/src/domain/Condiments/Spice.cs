namespace Kitchen;

public class Spice: ICondiment, IRawProcessing
{
    public string spice;

    public Spice(string type)
    {
        this.spice= type;
    }

    public Ingredient Season(Ingredient ingredient)
    {
        ingredient.Process($"Spiced with {this.spice}", this);

        return ingredient;
    }
}