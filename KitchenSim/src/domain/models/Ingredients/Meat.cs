namespace Kitchen;
public class Meat: Ingredient
{
    public Meat(string name): base()
    {
        this.name = name;
        state.Add("Raw");
    }
    public override void Process(string action, IProcessingType type)
    {   
        if (type is not IRawProcessing)
        {
            int index = state.FindIndex(s => s == "Raw");
            if (index != -1)
            {
                state.RemoveAt(index);
            }
        }
        state.Add(action);
    }
}