namespace Kitchen;

public class Salt: ICondiment, IRawProcessing
{
    public string type;

    public Salt(string type)
    {
        this.type = type;
    }

    public void Use(Ingredient ingredient)
    {
        ingredient.Process($"Salted with {type}", this);
        Logger.Instance.Log($"Salted {ingredient.name} with {type}.");
    }
}