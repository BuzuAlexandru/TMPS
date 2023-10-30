namespace Kitchen;

public class BurgerCook
{
    public Dish MakeVegilessBurger(IBurgerBuilder builder)
    {
        return builder.AddBun()
            .AddPatty()
            .AddCheese()
            .GetBurger();
    }

    public Dish MakeCompleteBurger(IBurgerBuilder builder)
    {
        return builder.AddBun()
            .AddPatty()
            .AddCheese()
            .AddGreens()
            .GetBurger();
    }
}