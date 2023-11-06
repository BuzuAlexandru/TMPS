namespace Kitchen;
using System.Collections.Generic;
public abstract class Ingredient: IngredientPrototype
{
    protected List<string> state; 
    protected string name = "";

    public Ingredient()
    {
        state = new List<string>();
    }
    public abstract void Process(string action, IProcessingType type);
    public virtual string GetName()
    {
        return name;
    }

    public virtual List<string> GetState()
    {
        return state;
    }
    
    public Ingredient Clone()
    {
        Ingredient clone = (Ingredient) this.MemberwiseClone();
        clone.name = this.name;
        clone.state = new List<string>(this.state);
        return clone;
    }
}