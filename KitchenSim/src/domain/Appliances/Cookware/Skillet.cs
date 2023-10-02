namespace Kitchen;
public class Skillet: ICookware, IHeatProcessing
{
    public Ingredient Prepare(Ingredient ingredient)
    {
        ingredient.Process("Fried", this);
        return ingredient;
    }
}