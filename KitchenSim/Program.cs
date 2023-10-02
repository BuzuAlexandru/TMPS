using Kitchen;
using static Kitchen.MyKitchen;
using static Kitchen.ConsolePrinter;

class Program
{
    static void Main()
    {
        MyKitchen kitchen = new();

        ICookware pan = new Skillet();
        IAppliance stove = new Stove(pan);
        IAppliance grill = new Grill();
        IAppliance cuttingBoard = new CuttingBoard();


        ICondiment salt = new Salt("Kosher salt");
        ICondiment pepper = new Spice("Black pepper");
        ICondiment basil = new Herb("Basil");
        ICondiment rosemary = new Herb("Rosemary");

        Dish dish = new("Steak with potatoes");

        Ingredient steak = new Meat("Ribeye Steak");
        steak = UseCondiment(salt, steak);
        steak = UseCondiment(pepper, steak);
        steak = UseAppliance(grill, steak);
        steak = UseCondiment(basil, steak);

        dish.AddIngredient(steak);

        Ingredient potatoes = new Vegetable("Sweet potatoes");
        potatoes = UseCondiment(salt, potatoes);
        potatoes = UseCondiment(pepper, potatoes);
        potatoes = UseAppliance(stove, potatoes);
        potatoes = UseCondiment(rosemary, potatoes);

        dish.AddIngredient(potatoes);

        PresentDish(dish);
    }
}

