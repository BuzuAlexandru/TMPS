using Kitchen;
using static Kitchen.MyKitchen;
using static Kitchen.ApplianceFactory;
using static Kitchen.CondimentFactory;
using static Kitchen.CookwareFactory;
using static Kitchen.IngredientFactory;
using static Kitchen.ConsolePrinter;

class Program
{
    static void Main()
    {
        Example3();

        PrintLogs();
    }

    static void Example3()
    {
        IAppliance grill = CreateGrill();

        ICondiment adapter = new ApplianceAdapter(grill);
        ILogger logger = new LoggerProxy(Logger.Instance, "1111");

        IFacade facade = new Facade(adapter, logger);
        facade.PerformOperation();
    }

    static void Example2()
    {
        BurgerCook cook = new();

        IBurgerBuilder lambBurgerBuilder = new LambBurgerBuilder();
        Dish burger1 = cook.MakeCompleteBurger(lambBurgerBuilder);
        PresentDish(burger1);
        
        IBurgerBuilder chickenBurgerBuilder = new ChickenBurgerBuilder();
        Dish burger2 = cook.MakeCompleteBurger(chickenBurgerBuilder);
        PresentDish(burger2);
    }

    static void Example1()
    {
        ICookware pan = CreateSkillet();
        IAppliance stove = CreateStove(pan);
        IAppliance grill = CreateGrill();
        IAppliance cuttingBoard = CreateCuttingBoard();


        ICondimentFactory condimentFactory = new CommonCondimentFactory();
        ICondiment salt = condimentFactory.CreateSalt();
        ICondiment spice = condimentFactory.CreateSpice();
        ICondiment herb = condimentFactory.CreateHerb();
        ICondiment powder = CreateSpice("Garlic powder");


        Ingredient steak = CreateMeat("Ribeye Steak");
        UseCondiment(salt, steak);
        UseCondiment(spice, steak);
        UseAppliance(grill, steak);
        UseCondiment(herb, steak);

        Ingredient potatoes = CreateVegetable("Sweet potatoes");
        UseAppliance(cuttingBoard, potatoes);
        UseCondiment(salt, potatoes);
        UseCondiment(spice, potatoes);
        UseAppliance(stove, potatoes);

        Ingredient tomatoes = CreateVegetable("Cherry tomatoes");
        UseCondiment(salt, tomatoes);
        UseCondiment(spice, tomatoes);
        UseCondiment(powder, tomatoes);
        UseAppliance(grill, tomatoes);

        Dish dish = new DishBuilder()
            .AddIngredient(steak)
            .AddIngredient(potatoes)
            .AddIngredient(tomatoes)
            .NameDish("Steak with vegies")
            .GetDish();
        
        PresentDish(dish);
    }
}

