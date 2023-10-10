namespace Kitchen;

public class BurgerCook
{
    public void MakeVegilessBurger(IBurgerBuilder builder)
    {
        builder.AddBun()
            .AddPatty()
            .AddCheese();
    }

    public void MakeCompleteBurger(IBurgerBuilder builder)
    {
        builder.AddBun()
            .AddPatty()
            .AddCheese()
            .AddGreens();
    }
}