namespace Kitchen;

public class StructuralFacade: IFacade
{
    protected ICondiment applianceAdapter;
    protected ILogger loggerProxy;
    protected Ingredient ingredientDecorator;
    protected IPrinter consolePrinter;

    public StructuralFacade(ICondiment adptr, ILogger lgr, Ingredient ing, IPrinter printer)
    {
        applianceAdapter = adptr;
        loggerProxy = lgr;
        ingredientDecorator = ing;
        consolePrinter = printer;
    }

    public void PerformOperation()
    {
        Dish dish = new("Potatoes");

        applianceAdapter.UseCondiment(ingredientDecorator, loggerProxy);

        dish.AddIngredient(ingredientDecorator);
        
        consolePrinter.PresentDish(dish);
    }
} 