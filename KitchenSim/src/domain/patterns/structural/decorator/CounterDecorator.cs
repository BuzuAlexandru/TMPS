namespace Kitchen;

abstract class CounterDecorator : Decorator
{
    private int counter = 0;
    public CounterDecorator(string name, Ingredient ing) : base(name, ing)
    {
        ingredient.state.Insert(0, $"Processed {counter} times");
    }

    public override void Process(string action, IProcessingType type)
    {
        base.Process(action, type);

        counter ++;
        ingredient.state[0] = $"Processed {counter} times";
    }
}