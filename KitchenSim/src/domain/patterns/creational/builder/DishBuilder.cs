namespace Kitchen;

public class DishBuilder
{
    private Dish dish = new("Unnamed dish");

    public DishBuilder AddIngredient(Ingredient ingredient)
    {
        dish.AddIngredient(ingredient);

        return this;
    }

    public DishBuilder NameDish(string name)
    {
        dish.name = name;

        return this;
    }

    public void Reset()
    {
        dish = new("Unnamed dish");
    }

    public Dish GetDish()
    {
        Dish result = dish;

        Reset();

        return result;
    }

}