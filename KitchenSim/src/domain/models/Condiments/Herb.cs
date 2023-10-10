namespace Kitchen;

public class Herb: ICondiment, IRawProcessing
{
    public string herb;

    public Herb(string type)
    {
        this.herb= type;
    }

    public void Use(Ingredient ingredient)
    {
        ingredient.Process($"Garnished with {herb}", this);
        Logger.Instance.Log($"Garnished {ingredient.name} with {herb}.");
    }
}