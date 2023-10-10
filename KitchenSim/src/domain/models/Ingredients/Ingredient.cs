namespace Kitchen;
using System.Collections.Generic;
public abstract class Ingredient: IngredientPrototype
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
    public Ingredient Clone()
    {
        Ingredient clone = (Ingredient) this.MemberwiseClone();
        clone.name = this.name;
        clone.state = new List<string>(this.state);
        return clone;
    }
}