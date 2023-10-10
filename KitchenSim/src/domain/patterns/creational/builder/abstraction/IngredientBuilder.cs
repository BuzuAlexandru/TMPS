namespace Kitchen;

public interface IIngredientBuilder
{
    public void UseSeasoning(ICondiment condiment);
    public void UseAppliance(IAppliance appliance);
    public void Reset();
    public Ingredient GetIngredient();
}