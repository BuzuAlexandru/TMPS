namespace Kitchen;
using System.Collections.Generic;
public class Dish
{
    public List<Ingredient> ingredients = new();
    public string name;

    public Dish(string name)
    {
        this.name = name;
    }
    public void AddIngredient(Ingredient ingredient)
    {
        this.ingredients.Add(ingredient);
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