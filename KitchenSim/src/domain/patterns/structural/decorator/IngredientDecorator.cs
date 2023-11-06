namespace Kitchen;

abstract class IngredientDecorator : Ingredient
{
    protected Ingredient ingredient;
    public IngredientDecorator(Ingredient ing) : base()
    {
        ingredient = ing;
    }
 
     public override string GetName()
    {
        return ingredient.GetName();
    }

    public override List<string> GetState()
    {
        return ingredient.GetState();
    }

    public virtual void SetIngredient(Ingredient ing)
    {
        ingredient = ing;
    }

    public override void Process(string action, IProcessingType type)
    {
        ingredient.Process(action, type);
    }
}