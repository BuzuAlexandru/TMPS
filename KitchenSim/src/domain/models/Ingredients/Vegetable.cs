namespace Kitchen;
using System.Collections.Generic;
public class Vegetable: Ingredient
{
    public Vegetable(string name): base(name)
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