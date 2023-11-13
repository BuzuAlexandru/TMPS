namespace Kitchen;
using System.Collections.Generic;
public class Dish: Subject<Dish>
{
    public List<Ingredient> ingredients;
    public string name;

    public Dish(string name)
    {
        ingredients = new List<Ingredient>();
        this.name = name;
    }
    
    public void AddIngredient(Ingredient ingredient)
    {
        this.ingredients.Add(ingredient);
        Notify();
    }

    public override void Notify()
    {
        foreach (IObserver<Dish> observer in observers)
        {
            observer.Update(this);
        }
    }

    public Dish Clone()
    {
        Dish clone = (Dish) this.MemberwiseClone();
        clone.name = this.name;
        clone.ingredients = new List<Ingredient>();
        foreach (IngredientPrototype prot in this.ingredients)
        {
            clone.AddIngredient(prot.Clone());
        }
        return clone;
    }
}