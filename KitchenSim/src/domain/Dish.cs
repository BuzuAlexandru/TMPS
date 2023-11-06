namespace Kitchen;
using System.Collections.Generic;
public class Dish: Subject
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