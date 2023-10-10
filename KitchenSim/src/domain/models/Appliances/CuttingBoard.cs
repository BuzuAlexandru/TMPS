namespace Kitchen;
public class CuttingBoard: IAppliance, IRawProcessing
{
    public void Use(Ingredient ingredient)
    {
        ingredient.Process("Sliced", this);
        Logger.Instance.Log($"Sliced {ingredient.name}.");
    }
}