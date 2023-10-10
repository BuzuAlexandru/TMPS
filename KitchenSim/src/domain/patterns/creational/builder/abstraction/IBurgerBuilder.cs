namespace Kitchen;

public interface IBurgerBuilder
{
    public IBurgerBuilder AddBun();
    public IBurgerBuilder AddPatty();
    public IBurgerBuilder AddCheese();
    public IBurgerBuilder AddGreens();
}