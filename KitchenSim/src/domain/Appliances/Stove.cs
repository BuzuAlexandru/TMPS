namespace Kitchen;
public class Stove: IAppliance, IHeatProcessing
{
    public ICookware cookware;

    public Stove(ICookware cookware)
    {
        this.cookware = cookware;
    }

    public void SetCookWare(ICookware equipment)
    {
        this.cookware = equipment;
    }

    public Ingredient Use(Ingredient ingredient)
    {
        return cookware.Prepare(ingredient);
    }
}