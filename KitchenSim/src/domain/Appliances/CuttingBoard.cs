namespace Kitchen;
public class CuttingBoard: IAppliance, IRawProcessing
{
    public Ingredient Use(Ingredient ingredient)
    {
        ingredient.Process("Chopped", this);
        return ingredient;
    }
}