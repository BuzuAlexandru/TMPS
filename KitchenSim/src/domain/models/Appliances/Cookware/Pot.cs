namespace Kitchen;
public class Pot: ICookware, IHeatProcessing
{
    public void Prepare(Ingredient ingredient)
    {
        ingredient.Process("Boiled", this);
        Logger.Instance.Log($"Boiled {ingredient.name}.");
    }
}