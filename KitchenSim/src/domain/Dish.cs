namespace Kitchen;
using System.Collections.Generic;
public class Dish
{
    public List<Ingredient> ingredients;
    public string name;

    public Dish(string name)
    {
        this.name = name;
        this.ingredients = new List<Ingredient>();
    }
    public void AddIngredient(Ingredient ingredient)
    {
        this.ingredients.Add(ingredient);
    }
}