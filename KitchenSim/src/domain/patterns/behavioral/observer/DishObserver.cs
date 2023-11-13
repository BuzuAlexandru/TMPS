namespace Kitchen;

public class DishObserver: IObserver<Dish>
{
    readonly ILogger logger;

    public DishObserver(ILogger logger)
    {
        this.logger=logger;
    }

    public static ILogger Logger
    {
        set { Logger = value; }
    }
    
    public void Update(Dish subject)
    {
        string ing_name = subject.ingredients[^1].GetName();
        logger.Log($"{ing_name} added to dish '{subject.name}'");
    }
}