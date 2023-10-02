namespace Kitchen;
using System.Collections.Generic;
public abstract class Ingredient
{
    public List<string> state;
    public string name;

    public Ingredient(string name)
    {
        this.name = name;
        this.state = new List<string>();
    }
    public virtual void Process(string action, IProcessingType type)
    {
        this.state.Add(action);
    }
}