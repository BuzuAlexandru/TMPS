namespace Kitchen;
public interface ICookware
{
    public void Prepare(Ingredient ingredient, ILogger logger);
}