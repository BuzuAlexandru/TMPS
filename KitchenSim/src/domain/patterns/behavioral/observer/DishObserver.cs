namespace Kitchen;

public class DishObserver: IObserver
{
    public void Update(Subject subject)
    {
        Dish dish = (Dish)subject;
        string ing = dish.ingredients[^1].GetName();
        Logger.Instance.Log($"{ing} added to dish '{dish.name}'");
    }
}