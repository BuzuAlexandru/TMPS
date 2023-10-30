namespace Kitchen;
public interface ICondiment
{
    public void UseCondiment(Ingredient ingredient, ILogger logger);
}