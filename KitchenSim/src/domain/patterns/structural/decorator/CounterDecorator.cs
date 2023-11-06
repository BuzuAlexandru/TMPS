using System.Reflection.Metadata.Ecma335;

namespace Kitchen;

class CounterDecorator : IngredientDecorator
{
    private int counter = 0;
    public CounterDecorator(Ingredient ing) : base(ing)
    {
        CountState();

        ingredient.GetState().Insert(0, $"Processed: {counter} time(s)");
    }

    private void CountState()
    {
        counter = ingredient.GetState().Count;
        int index = ingredient.GetState().FindIndex(s => s == "Raw");

        if (index != -1)
            {
                counter -= 1;
            }
        if (new string(ingredient.GetState()[0].Take(10).ToArray()) == "Processed:")
            {
                counter -= 1;
            }
    }

    public override void SetIngredient(Ingredient ing)
    {
        base.SetIngredient(ing);

        CountState();

        ingredient.GetState().Insert(0, $"Processed: {counter} time(s)");
    }

    public override void Process(string action, IProcessingType type)
    {
        base.Process(action, type);

        CountState();

        ingredient.GetState()[0] = $"Processed: {counter} time(s)";
    }
}