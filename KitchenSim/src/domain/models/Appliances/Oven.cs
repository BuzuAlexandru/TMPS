namespace Kitchen;
public class Oven: IAppliance, IHeatProcessing
{
    public void Use(Ingredient ingredient)
    {
        ingredient.Process("Baked", this);
        Logger.Instance.Log($"Baked {ingredient.name}.");
    }
}