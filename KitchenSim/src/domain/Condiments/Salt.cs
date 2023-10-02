namespace Kitchen;

public class Salt: ICondiment, IRawProcessing
{
    public string type;

    public Salt(string type)
    {
        this.type = type;
    }

    public Ingredient Season(Ingredient ingredient)
    {
        ingredient.Process($"Salted with {this.type}", this);
        return ingredient;
    }
}