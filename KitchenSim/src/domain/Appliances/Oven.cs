namespace Kitchen;
public class Oven: IAppliance, IHeatProcessing
{
    public Ingredient Use(Ingredient ingredient)
    {
        ingredient.Process("Baked", this);
        return ingredient;
    }
}