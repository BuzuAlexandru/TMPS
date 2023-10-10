namespace Kitchen;
public class Grill: IAppliance, IHeatProcessing
{
    public void Use(Ingredient ingredient)
    {
        ingredient.Process("Grilled", this);
        Logger.Instance.Log($"Grilled {ingredient.name}.");
    }
}