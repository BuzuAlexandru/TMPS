namespace Kitchen;
public class Skillet: ICookware, IHeatProcessing
{
    public void Prepare(Ingredient ingredient)
    {
        ingredient.Process("Fried", this);
        Logger.Instance.Log($"Fried {ingredient.name}.");
    }
}