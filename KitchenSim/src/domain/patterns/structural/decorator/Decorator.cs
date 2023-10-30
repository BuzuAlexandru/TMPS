namespace Kitchen;

abstract class Decorator : Ingredient
{
    protected Ingredient ingredient;
    public Decorator(string name, Ingredient ing) : base(name)
    {
        ingredient = ing;
    }

    public void SetIngredient(Ingredient ing)
    {
        ingredient = ing;
    }

    public override void Process(string action, IProcessingType type)
    {
        base.Process(action, type);
    }
}