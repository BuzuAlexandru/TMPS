namespace Kitchen;
using static Kitchen.MyKitchen;
using static Kitchen.ApplianceFactory;
using static Kitchen.CondimentFactory;
using static Kitchen.IngredientFactory;
 
public class ChickenBurgerBuilder: IBurgerBuilder
{
        Dish burger = new("Chicken Burger");
        readonly IAppliance grill = CreateGrill();
        readonly IAppliance cuttingBoard = CreateCuttingBoard();

        readonly ICondiment salt = CreateSalt("Kosher salt");
        readonly ICondiment pepper = CreateSpice("Black pepper");
        readonly ICondiment ketchup = CreateSauce("Ketchup");
        readonly ICondiment mayonnaise = CreateSauce("Mayonnaise");

    public IBurgerBuilder AddBun()
    {
        Ingredient bun = CreateBread("Brioche bun");
        UseAppliance(grill, bun);

        burger.AddIngredient(bun);

        return this;
    }
    public IBurgerBuilder AddPatty()
    {
        Ingredient patty = CreateMeat("Chicken patty");
        UseCondiment(salt, patty);
        UseCondiment(pepper, patty);
        UseAppliance(grill, patty);
        UseCondiment(ketchup, patty);
        UseCondiment(mayonnaise, patty);

        burger.AddIngredient(patty);

        return this;
    }
    public IBurgerBuilder AddCheese()
    {
        Ingredient cheese = CreateCheese("Cheddar cheese");
        UseAppliance(grill, cheese);
        burger.AddIngredient(cheese);

        return this;
    }
    public IBurgerBuilder AddGreens()
    {
        Ingredient lettuce = CreateVegetable("Lettuce");
        Ingredient tomato = CreateVegetable("Tomato");
        UseAppliance(cuttingBoard, tomato);

        burger.AddIngredient(lettuce);
        burger.AddIngredient(tomato);
        
        return this;
    }

    public void Reset()
    {
        burger = new("Chicken Burger");
    }

    public Dish GetBurger()
    {
        Dish result = burger;

        Reset();

        return result;
    }
}