namespace Kitchen;
public class IngredientFactory
{
    public static Ingredient CreateCereal(string name)
    {
        return new Cereal(name);
    }
    public static Ingredient CreateEggs(string name)
    {
        return new Eggs(name);
    }
    public static Ingredient CreateMeat(string name)
    {
        return new Meat(name);
    }
    public static Ingredient CreateVegetable(string name)
    {
        return new Vegetable(name);
    }
    public static Ingredient CreateCheese(string name)
    {
        return new Cheese(name);
    }
    public static Ingredient CreateBread(string name)
    {
        return new Bread(name);
    }
}