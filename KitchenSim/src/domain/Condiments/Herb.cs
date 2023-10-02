namespace Kitchen;

public class Herb: ICondiment, IRawProcessing
{
    public string herb;

    public Herb(string type)
    {
        this.herb= type;
    }

    public Ingredient Season(Ingredient ingredient)
    {
        ingredient.Process($"Garnished with {this.herb}", this);

        return ingredient;
    }
}