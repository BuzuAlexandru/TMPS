namespace Kitchen;
public class Grill: IAppliance, IHeatProcessing
{
    public Ingredient Use(Ingredient ingredient)
    {
        ingredient.Process("Grilled", this);
        return ingredient;
    }
}