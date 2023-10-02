namespace Kitchen;
public class Pot: ICookware, IHeatProcessing
{
    public Ingredient Prepare(Ingredient ingredient)
    {
        ingredient.Process("Boiled", this);
        return ingredient;
    }
}