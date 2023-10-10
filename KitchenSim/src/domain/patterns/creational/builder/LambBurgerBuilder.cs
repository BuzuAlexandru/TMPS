namespace Kitchen;
using static Kitchen.MyKitchen;
using static Kitchen.ApplianceFactory;
using static Kitchen.CondimentFactory;
using static Kitchen.IngredientFactory;
 
public class LambBurgerBuilder: IBurgerBuilder
{
        Dish burger = new("Lamb Burger");
        readonly IAppliance grill = CreateGrill();
        readonly IAppliance cuttingBoard = CreateCuttingBoard();

        readonly ICondiment salt = CreateSalt("Kosher salt");
        readonly ICondiment pepper = CreateSpice("Black pepper");
        readonly ICondiment cumin = CreateHerb("Cumin");
        readonly ICondiment yogurt = CreateSauce("Greek yogurt");

    public IBurgerBuilder AddBun()
    {
        Ingredient bun = CreateBread("Pretzel bun");
        UseAppliance(grill, bun);

        burger.AddIngredient(bun);

        return this;
    }
    public IBurgerBuilder AddPatty()
    {
        Ingredient patty = CreateMeat("Lamb patty");
        UseCondiment(salt, patty);
        UseCondiment(pepper, patty);
        UseCondiment(cumin, patty);
        UseAppliance(grill, patty);
        UseCondiment(yogurt, patty);

        burger.AddIngredient(patty);

        return this;
    }
    public IBurgerBuilder AddCheese()
    {
        Ingredient cheese = CreateCheese("Feta cheese");
        UseAppliance(grill, cheese);
        burger.AddIngredient(cheese);

        return this;
    }
    public IBurgerBuilder AddGreens()
    {
        Ingredient mint = CreateVegetable("Mint");
        Ingredient onion = CreateVegetable("Red onion");
        UseAppliance(cuttingBoard, onion);

        burger.AddIngredient(mint);
        burger.AddIngredient(onion);
        
        return this;
    }

    public void Reset()
    {
        burger = new("Lamb Burger");
    }

    public Dish GetBurger()
    {
        Dish result = burger;

        Reset();

        return result;
    }
}