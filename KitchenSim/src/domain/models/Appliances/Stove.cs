namespace Kitchen;
public class Stove: IAppliance, IHeatProcessing
{
    ICookware _cookware;

    public Stove(ICookware cookware)
    {
        this._cookware = cookware;
    }

    public void SetCookWare(ICookware equipment)
    {
        this._cookware = equipment;
    }

    public void UseAppliance(Ingredient ingredient, ILogger logger)
    {
        _cookware.Prepare(ingredient, logger);
    }
}