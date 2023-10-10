namespace Kitchen;
public class Meat: Ingredient
{
    public Meat(string name): base(name)
    {
        this.state.Add("Raw");
    }
    public override void Process(string action, IProcessingType type)
    {   
        if (type is not IRawProcessing)
        {
            int index = this.state.FindIndex(s => s == "Raw");
            if (index != -1)
            {
                this.state.RemoveAt(index);
            }
        }
        this.state.Add(action);
    }
}